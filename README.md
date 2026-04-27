# CS5136 - Langsam 418++

### Authors
* Dylan Bok
* Matt Heeter
* JP Vargas
* Jared Walden
* Kaleb Wells



## Demo Video

[Demo video link](https://www.youtube.com/watch?v=DGJTyQ9QYgU)

Note that the demo is missing the ambient sound, such as the conversations of surrounding people, due to the method we used for screen capture.

## Design

For our design, our overall objective was to maintain a realistic feeling setting, while leveraging some of the possible benefits of transferring the room into a VR world. In order to achieve this goal, we used pre-existing assets for the furniture and textures, which are of good quality, versus creating our own, which best match what exists in the real Langsam 418. We chose to keep the overall structure of the room and its surroundings, making a few changes such as the style of light fixtures, removing some of the tables in the middle of the room, and making minor changes to the surroundings while keeping the ambiance very similar. 

Our choices to enhance the room were to support further interactivity in the room and to showcase a major way in which VR can turn the world into an out-of-this-world experience. The first touch of interaction is the sound coming from people and the surroundings, as one normally hears in Langsam. This, combined with the text from the people within the room, helps the room feel alive. The next is the addition of the whiteboard. Users in the VR world can write, type, and add images to the board in real time. This enables collaboration both in and out of the VR setting. For example, someone can be sitting in VR drawing on the board during the lecture, and because it uses a Miro board (pictured below), you can log into it via the web on the real screen and see what is being edited in real time, adding interaction between VR and the real world. 


<img width="2541" height="1419" alt="image" src="https://github.com/user-attachments/assets/a1ae1919-d3a2-4cd1-b914-50c96063387c" />


The last major choice we made to enhance the room is to enable users to change the surroundings of the room.  The currently supported options are mountain ranges, a Minecraft world, and outside of Saturn’s orbit in space. We felt that doing this would help change the vibes of the room, depending on what is needed for the occasion. The changes that can be made based on the setting can also be creative and really alter the room, such as the zero gravity mode triggered when you change the location to space (pictured below).


<img width="2550" height="1420" alt="image" src="https://github.com/user-attachments/assets/0ced2318-7b7c-47f0-ab84-e6f5d4a00aa6" />

## Process

To make this application, we used Unity’s VR development environment. We utilized GitHub for our version control, supporting our ability to collaborate asynchronously. We also used the Unity asset library and other online asset libraries, such as [Sketchfab](https://sketchfab.com/feed), to get models for the furniture and room surrounding options. Another unique integration we have is using a [live connection via the web](https://github.com/t-34400/SimpleUnity3DWebView) to integrate the Miro board onto the screen in our version of Langsam 418. We deployed our project onto the Meta Quest 3S for development and testing, but we believe it should work on most, if not all, other Meta devices since our solution doesn’t require the use of extra special hardware. 

Our production process changed throughout the project. To begin, we would meet as a whole group to brainstorm and discuss the overall path and big-ticket items we wanted to include in our project. We would come up with ideas and then draw them out as storyboards (examples shown below) to document and communicate our ideas and the style we are going for. Even though we aren’t all the best artists, we found this to be a very effective means of communication, which helped us avoid major misunderstandings, especially as we began to work asynchronously. Working asynchronously was very helpful, but came with its own challenges, which will be discussed in the next section. The last important part of our system was the use of PRs to check one another's work and ensure that we are all still on the same page before moving on with changes. This was essential because otherwise we would consistently be overriding one another's work.

<img width="1444" height="1660" alt="image" src="https://github.com/user-attachments/assets/e63ec7c2-1fc2-44b8-8557-7bb9c19e6766" />

<img width="1446" height="1571" alt="image" src="https://github.com/user-attachments/assets/ff1de284-b675-4a74-a79e-1a0aefd52d1c" />

## Challenges

We faced two main challenges in this project. The first was determining the most effective way to collaborate. Generally, in programming projects, you can use GitHub to work on separate parts of a project and merge them together, allowing GitHub to handle conflicts. With Unity, however, the process is not so simple. The nature of the backend of Unity makes this a challenge, as well as the work we’re doing itself. Just about every change we make has an effect on another that someone else is making because they all share the same virtual environment. Using lots of communication and systems of PRs and reviews, we were able to overcome this problem.

The other challenge we faced was testing our project in the development stages. Having only one headset which would go home with the same person every day, we would only be able to test what we had developed at specific times when we were together, or request and explain the tests needed to run to our group member with the device themselves. While this made development slow at times, it didn't have a large negative impact on our ability to complete the project. Unity has other ways that we can move around and interact with the environment for testing purposes, and we were able to plan ahead when we could test our VR Headset-specific capabilities for when we could meet together again.

## Future Work

The main thing we would want to add in the future is a more structured version to interact with our room, where users are walked through the features that we implemented that may be missed without intentional searching. We came up with a story (part of the storyboard shown below) about setting up the room for presentations and had some more ideas for tools and features, but we ran out of time before the deadline. Even just adding arrows or other markers to lead the user could have been very helpful to quickly direct them through our world. This would be an optional feature that could be turned on and off.

<img width="1335" height="2068" alt="image" src="https://github.com/user-attachments/assets/eaedc0e2-9995-476d-8972-af01062e7670" />

## Use of AI

Since this project was more visually creative and not programming-heavy, we did not use a lot of AI. The main ways we leveraged AI were for search capabilities and to tweak parameters for our Zero-gravity space setting. Using ChatGPT, we were able to find which libraries/APIs existed that would enable support for web connections in our VR world to have the Miro board. We also used it to get better parameters for the zero-gravity mode. Using AI, we quickly figured out how to give objects a velocity to make it clear that gravity has been turned off, and learned which other values we could modify, such as drag and linear damping ot further enhance the effect. 

## Collaboration with other Students
Since we had such a large group and a wide breadth of experience working in VR, we didn’t 
need much help outside of our group, such as other students or the TA, to get our project working.
