# Aliens-vs.-Predator-Test

Initial setup of the project was done. 

Switching logic is added. Also, UI for combined view was added. Basic effects for night, thermal and em vision were added.

Bug fixes:
- fix a bug for a night vision with inverse colors (had to place a black image in the background in the UI)
- fix thermal vision by adding or doubling meshes of charecters to create an orange glow (have to check the plugin shader and do some tweaks to the charecters, may have to do some additional research to make it look realistic)
- fix lighting issues in thermal vision
- fix lacking green glowing effect of charecters in the EM vision.

Improvements and features:
- add noise effect to night vision, add vignette effect (can be done by using post processing)
- add horizontal stripes to EM vision (add custom shader)
- add vision switch effects (at least some simple fade in and fade out with animation curve)
- add move in effect for UI elements (fly in animation or/and fade in and out animations)
- add sound effects (various noises and background sounds in varios vision modes, vision mode switching sound effect)
- refactor switch code to use input manager (allows key bindings)
- refactor switch code to use dependency injection (depends on the other aspects of the project)
- check and optimize performance if necessary (further lower te quality of render texture)
