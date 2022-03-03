using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> membersList;

        public List<Person> MembersList 
        {
            get => this.membersList;
            set => this.membersList = value; 
        }

        public Family()
        {
            this.MembersList = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.MembersList.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.membersList.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
