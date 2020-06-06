using System;
using System.Collections.Generic;
using System.Linq;

namespace TestFirstDevelopment
{
    public class GroupMaker
    {
        private readonly int _groupCount;        
        public GroupMaker(int groupCount)
        {
            _groupCount = groupCount;
        }

        public List<List<Measurement>> MakeGroup(List<Measurement> measurements)
        {
            var groups = new List<List<Measurement>>();
            for (int i = 0; i < measurements.Count; i += _groupCount)
            {
                var group = measurements.Skip(i).Take(_groupCount).ToList();
                groups.Add(group);
            }
            return groups;
        }
    }
}