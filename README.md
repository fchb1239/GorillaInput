# Gorilla Input
A simple library to test your mods DO NOT RELEASE A MOD THAT REQUIRES THIS!

# Documentation
Import ```GorillaInput.dll```

Include ```using GorillaInput;```

Get controller input
```
bool isLeftHand = true;

if (ControllerInput.GetInput(isLeftHand, InputType.triggerButton))
{
  //Your code here
}
```
