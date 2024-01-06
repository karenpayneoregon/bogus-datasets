# About

Contains a single extension method using in BogusNorthWindLibrary to set the Photo property from the Picture property in the Category model.

```csharp
public static class ImageExtensions
{
    public static Bitmap ByteToImage(this byte[] sender)
    {
        MemoryStream mStream = new();
        byte[] bytes = sender;
        mStream.Write(bytes, 0, Convert.ToInt32(bytes.Length));
        Bitmap bm = new(mStream, false);
        mStream.Dispose();
        return bm;
    }
}
```