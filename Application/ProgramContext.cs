using Application.Implementation;
using Application.Interface;
using StructureMap;

namespace Application
{
    internal class ProgramContext
    {
        private List<IProgram> _programs;

        public ProgramContext()
        {
            var container = new Container(_ => {
                _.For<IProgram>().Use<AutoResetEventProgram>();
                _.For<IProgram>().Use<IsAssignableFromProgram>();
            });

            _programs = new List<IProgram> {
                container.GetInstance<AutoResetEventProgram>(),
                container.GetInstance<IsAssignableFromProgram>()
            };
        }

        internal void ShowAllOptions()
        {
            for (var i = 0; i < _programs.Count; i++)
            {
                Console.WriteLine($"Option {i}: {_programs[i].GetType().Name}");
            }
        }

        internal void RunWith(int option)
        {
            _programs[option].Run();
        }
    }
}
