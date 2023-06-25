using System;
using System.Collections.Generic;
using Architecture;

namespace Scenes.Scripts
{
    public class SceneConfigExample : SceneConfig
    {
        public override Dictionary<Type, Interactor> CreateAllInteractors()
        {
            var interactorsMap = new Dictionary<Type, Interactor>();
            CreateInteractor<BankInteractor>(interactorsMap);
            return interactorsMap;
        }

        public override Dictionary<Type, Repository> CreateAllRepositories()
        {
            var repositoriesMap = new Dictionary<Type, Repository>();
            CreateRepository<BankRepository>(repositoriesMap);
            return repositoriesMap;
        }
    }
}