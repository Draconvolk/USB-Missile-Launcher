# USB-Missile-Launcher
USB Missile Launcher
<pre>
This contains the DLL with the commands to be sent to the USB missile launcher,
the USBLib.dll used to communicate with the missile launcher, and a simple console
application that uses this to send the commands to the missile launcher.

This project was created to replace the very poorly put together user interface
that shipped with the desktop USB Missile Launcher. I decompiled the code to
extract the commands being transmitted to the USB toy and then built a new class 
to organize the code into two pieces.  I separated out the interface, choosing a simple
text console vs. the previous clunky GUI, and the byte arrays that trigger the 
various actions of the missile launcher hardware.  I did not like how hard it was to
be precise when aiming the missiles, if I'm trying to get a coworkers attention,
I want to get the right coworker.
  
In the testing of the commands I discovered there had been a few software limitations
implemented that were not hardware limitations, such as turning radius and motor 
activation time, and removed them.  I also discovered the ability to toggle the LED 
on and off.  With a little code hunting, and some trial and error, I was able to 
determine the shortest number of milliseconds of activity to send to the motors 
involved in the missile launcher's movement, up/down/left/right, to "fine-tune" the 
aiming and allow for more accurate targeting.  To few ms and the motors wouldn't 
move at all. Too many and the missile would quickly aim past your target.  This lead 
to much greater control over the hardware than what had been shipped with the product
originally.
  
This is a <a href="https://www.amazon.com/gp/product/B004SAYO46/ref=ppx_yo_dt_b_search_asin_title?ie=UTF8&psc=1">link</a> to the amazon product page for the <a href="https://www.amazon.com/gp/product/B004SAYO46/ref=ppx_yo_dt_b_search_asin_title?ie=UTF8&psc=1">Dream Cheeky 908 Thunder Missile Launcher</a>.
  
I don't have any type of referral so I don't get anything out of this, I just wanted to
show which product this code works on.  If you happen to have this product, feel
free to use this code as you see fit for personal non-commercial use.
</pre>

Draconvolk
