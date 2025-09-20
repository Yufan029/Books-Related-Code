1. global using
  using statement contained in one file, (GlobalUsings.cs), then all the other file no need to include the using anymore.

2. implicit using
  include a bunch of using statement by default, like System.Linq

3. null state analysis
  compiler identify attempts to access reference that may be null

4. which one is nullable
    Product nullable
      Product?[] arr1 = new Product?[] { kayak, lifejacket, null }; // OK
      Product?[] arr2 = null;                                       // Not OK
    
    Array nullable
      Product[]? arr1 = new Product?[] { kayak, lifejacket, null }; // Not OK
      Product[]? arr2 = null;                                       // OK
    
    Both can be null
      Product?[]? arr1 = new Product?[] { kayak, lifejacket, null }; // OK
      Product?[]? arr2 = null;                                       // Also OK