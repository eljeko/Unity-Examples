# Xml parsing

This example shows how to load an XML file from disk and parse and show its content

## StreamingAssets

The demo.xml file is in:

```
Assets/StreamingAssets/xml/demox.xml
```

The example uses:

```
Application.streamingAssetsPath
```

to build the path (link to [docs](http://docs.unity3d.com/ScriptReference/Application-streamingAssetsPath.html))

This is a special path (Read Only) in your assets dir and will be packaged with the final build and could be read by:

```
System.IO.File.ReadAllText (PATH);
```

## xpath

The xml APIs are based on [xpath](http://en.wikipedia.org/wiki/XPath) to find the elements and attributes in xml, the implementation may differ from the *Recommendation*.