﻿using System;
using System.Collections.Generic;
using HomeReval.Domain;
using HomeReval.Validator;
using UnityEngine.UI;
using Views;
using Windows.Kinect;

namespace HomeReval.Services
{
    class ExerciseService : IExerciseService
    {
        private ExerciseValidator exerciseValidator;

        public void StartNewExercise(Exercise exercise, IBodyDrawer exampleBodyDrawer)
        {
            exerciseValidator = new ExerciseValidator(exercise, exampleBodyDrawer);
        }

        public ExerciseScore Check(ConvertedBody bodyLive)
        {
            return exerciseValidator.Check(bodyLive);
        }

        public ExerciseValidator.ValidatorState State()
        {
            return exerciseValidator.State;
        }

        public void Stop()
        {
            exerciseValidator = null;
        }

        public ConvertedBody Convert(Body body, List<Map.Mappings> jointMappings)
        {
            return new ConvertedBody(body, jointMappings);
        }

        public string Progression()
        {
            return exerciseValidator.Progression();
        }
    }
}
