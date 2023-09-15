var scene = new scene ();
var cylinder = new cylinder ();
cylinder.name = "test";
var node = RootNode.createChildNode = "cylinder";
var material = newLambertMaterial() {
  DiffuseColor = new vector 3 (color.LightBlue)
  };
material.Name = "Lambert";
node.Material = material;
var light = new Light() {
  LightType = LightType.point
  };
var output = "@ /Type/test.fbx";
Scene.Save (output, FileFormat.FBX 7500ASCII);
delay(10000);
FileStream fs = File.Open("@/home.py", FileMode.Open, FileAccess.Write, FileShare.None);
  
