using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType)) //gonderilen validatorType Bir IValidator deyilse error versin 
            {
                throw new System.Exception("This not Validator Type");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); //REfLECTION//=>>//run Time da instance yaratmaq ucun lazim olan koddur!
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];   //carValidatora lazim olan type tapmaq ucun lazim olan koddur! ilkini 0-cisini tapiriq//:AbstractValidator<(->Car<-)> Car tapiriq
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); //Burda ise lazim olan parametleri tapiriq yeni entityType=car  -- public IResult Add(Car ->car<-)--tapiriq
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity); //her birini gez validatTool istifade ederek Validate ele
            }
        }
    }
}
