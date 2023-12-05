using System;

namespace Tymakov13
{
    internal class Build
    {
        private Collectionsofbuildings[] builds = new Collectionsofbuildings[10];

        public Collectionsofbuildings[] Builds
        {
            get { return builds; }
        }

        public Collectionsofbuildings this[int index]
        {
            get
            {
                if (index >= 0 && index < builds.Length)
                {
                    return builds[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("непон ошибк");
                }
            }
            set
            {
                if (index >= 0 && index < builds.Length)
                {
                    builds[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Непон ошибк");
                }
            }
        }

        public void Collection(Collectionsofbuildings builds1)
        {
            builds[builds1.Number] = builds1;
        }
    }
}