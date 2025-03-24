# Coffee Assistant - Unity - ROS - GPT

This repository is part of the ICA project, which aims to solve the **Wozniak Coffee Test**.  
In this section, an **Augmented Reality (AR)** setup was created using an **AI chatbot** to guide a person step-by-step in serving a cup of coffee.

We recommend using **two machines**, with **Linux** to run ROS commands and **Windows** to run Unity.  
This can be done using two different physical devices or a single machine with a **virtual machine**.

> _<insert here a general demonstration video>_


## System Dependencies

This repository is a branch of the **I2CA** project.  
To run this program, make sure to follow all the setup instructions from the **`wozniak_coffee_test`** repository, as this project depends on the **Coffee Assistant** available there.


## Headset Setup

You will also need to install the **Meta Quest Link** desktop application to connect your headset to your machine.  
Follow the steps provided in the app to detect your **Meta** device.

- The headset should be connected via **cable** to ensure full functionality with Unity.
- Scan your environment and ensure the **three required objects** are detected and tagged properly.
- We recommend assigning the tag **"OTHER"**, since the headset’s auto-scanner rarely uses this tag by default.

> _<insert here a screenshot>_


## Unity Setup

- Install **Unity Hub** and make sure you have an active license.
- Install **Unity version 2022.3.32f1**.
- Clone this repository and add the folder `unity_project` to your Unity Hub project list.

This Unity project uses the **ROS# package**, which acts as an interface between **Unity and ROS (via rosbridge)**.

### Project Configuration Checklist:

In the **Hierarchy**:
- Select the `ros_holder` component.
  - In the **Inspector**, make sure the **IP address** matches the machine that will be communicating with Unity.
- Select the `scripts_holder` component.
  - In the **Inspector**, make sure the `"Anchor_name"` parameter exactly matches the tag names used for the scanned objects (from the **Headset Setup** step).
  - Make sure the parameters **"obj1"**, **"obj2"**, and **"obj"** correspond to the three required objects (e.g., `"sweetener"`, `"cup"`, and `"coffee maker"`).

<img width="306" alt="Image" src="https://github.com/user-attachments/assets/74e30cca-1fe0-45d8-a486-aaa728945ab2" />


## Running the Program

1. First, run the Unity scene by clicking the **Play** button.
2. Then, to establish communication between **Unity (Machine 1)** and **ROS (Machine 2)**, execute the following command on the ROS side:

```
roslaunch rosbridge_server rosbridge_websocket.launch
```


3. To start the Coffee Assistant, run:

```
ros2 launch robot_control_language realsense.launch.py
```


At this point, the program is running. To start interacting with the AI assistant, simply send the first message.  
When you are ready to begin the task, make a **thumbs-up (👍)** gesture with your hand to signal the system.

---

