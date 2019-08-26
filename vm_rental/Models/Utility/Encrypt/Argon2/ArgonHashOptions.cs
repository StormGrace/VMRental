﻿

namespace vm_rental.Models.Utility.Encrypt.Argon2
{
  //Argon hashing options for the ArgonHasher, used during the Verify and Hash phases.
  public class ArgonHashOptions : IHashOptions
  {
    //Default Hashing Options.
    //Changing these options will affect all future hashes.
    //Each Parameter adds to the overall computational cost.
    private struct Default
    {
      //Type of the Argon Hashing Algorithm. [Not Yet Implemented - Changing it won't affect the hashing]
      public const string Algorithm = "argon2id";
      //Version of the Argon Hashing Algorithm. [Not Yet Implemented - Changing it won't affect the hashing]
      public const string Version = "1.2.1";
      //The amount of RAM used during the hashing phase, affecting the memory cost (measured in Kbits).
      public const int MemorySize = 1024 * 1024;  //1GB 
      //The number of Iterations during the hashing phase, affecting the time cost.
      public const int Iterations = 1;  
      //The number of Cores used during the hashing phase, affecting the degree of parallelism.
      public const int Parallelism = 16; //4 Cores
    }
    public ArgonHashOptions()
    {
      Algorithm   = Default.Algorithm;
      Version     = Default.Version;
      MemorySize  = Default.MemorySize;
      Iterations  = Default.Iterations;
      Parallelism = Default.Parallelism;
    }

    public ArgonHashOptions(string algorithm, string version, int memorySize, int iterations, int parallelism)
    {
      Algorithm = algorithm;
      Version = version;
      MemorySize = memorySize;
      Iterations = iterations;
      Parallelism = parallelism;
    }

    public string Algorithm { get; set; }
    public string Version { get; set; }
    public int MemorySize { get; set; }
    public int Iterations { get; set; }
    public int Parallelism { get; set; }

    public static ArgonHashOptions Defaults
    {
      get
      {
        return new ArgonHashOptions();
      }
    }
  }
}