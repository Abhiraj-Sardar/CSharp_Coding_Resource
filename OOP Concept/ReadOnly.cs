// readonly is a keyword used primarily to declare that a field can only be assigned a value during its declaration 
// or inside a constructor of the same class. Once the constructor finishes executing, 
// the field becomes immutable and its value or reference cannot be changed.


namespace ReadOnly
{
    public class FileManager
    {
        // Assigned at declaration
        public readonly string DefaultExtension = ".txt";

        // Assigned inside the constructor (can be resolved at runtime)
        public readonly string ConnectionString;

        public FileManager(string configPath)
        {
            ConnectionString = FetchFromConfigFile(configPath);
        }

        public void UpdatePath()
        {
            // COMPILER ERROR: A readonly field cannot be assigned to 
            // after the constructor has finished.
            ConnectionString = "new_path.db";
        }
    }
}