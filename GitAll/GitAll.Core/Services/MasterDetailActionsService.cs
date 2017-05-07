using System;
using GitAll.Core.Services.Interfaces;
using System.Collections.Generic;

namespace GitAll.Core.Services
{
    public class MasterDetailActionsService : IMasterDetailActionsService
    {
        private Dictionary<string, Action> _actionsDictionary;

        public MasterDetailActionsService()
        {
            _actionsDictionary = new Dictionary<string, Action>();
        }

        public Action this[string key]
        {
            get
            {
                if(_actionsDictionary.ContainsKey(key))
                {
                    return _actionsDictionary[key];
                }

                return () => 
                {
                    System.Diagnostics.Debug.WriteLine($"{key} not include in dictionary");
                };
            }
            set
            {
                if(_actionsDictionary.ContainsKey(key))
                {
                    _actionsDictionary.Remove(key);
                }

                _actionsDictionary.Add(key, value);
            }
        }

        
    }
}
