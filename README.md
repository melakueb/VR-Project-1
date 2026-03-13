# VR Project 1: Napa Valley AR Knick-Knack

## Description
This project is an **Augmented Reality knick-knack** built using Unity and Vuforia. The application displays a small 3D vineyard-themed scene on top of a tracked merge cube when viewed through a webcam.

The project represents **Napa Valley, California**, which I visited last summer for my sister’s bachelorette trip. When the cube is detected, the AR scene appears on top of it. Each face of the cube also displays useful information such as the location name, the current weather, the local time, and a personal memory caption.

---

## Repository
**GitHub Repository:**  
[VR-Project-1](https://github.com/melakueb/VR-Project-1)

---

## Artifacts

### Scene Overview
![Scene](https://github.com/melakueb/VR-Project-1/blob/main/images/scene.png)
This screenshot shows the AR knick-knack scene appearing on top of the merge cube when detected by the webcam. Each side of the cube displays readable information using world-space UI text panels.

Cube faces include:

- **Location Name**
- **Current Weather**
- **Local Time**
- **Memory Caption**

### 3D Models Used

#### Models from External Sources

| Model | Source |
|------|------|
| Green Bush | [Link for Bush](https://www.fab.com/listings/581e1057-ee3e-4c64-bf85-4ea5a3194a0c)|
![Bush](https://github.com/melakueb/VR-Project-1/blob/main/images/bush.png)
| PSX Old House | [Link for House](https://www.fab.com/listings/88a25b2a-9dc1-4e5d-8aca-746e1fff91fb)|
![House](https://github.com/melakueb/VR-Project-1/blob/main/images/house.png)
| Wine Barrel | [Link for Barrel](https://www.fab.com/listings/e629a77a-566b-4ddb-96e0-9a314e3ea5f6)|
![Barrel](https://github.com/melakueb/VR-Project-1/blob/main/images/barrel.png)

#### Models Created by Me

| Model | Creation Method |
|------|------|
| Grapes | Generated using Meshy AI and modified in Blender |
![Grapes](https://github.com/melakueb/VR-Project-1/blob/main/images/grapes.png)
| Wine Glass | Created in Blender following a tutorial |
![Scene](https://github.com/melakueb/VR-Project-1/blob/main/images/wine.png)

Wine glass tutorial used:  
[How to create a wine glass in 1 Minute in Blender Tutorial](https://www.youtube.com/watch?v=4edZZAm-qdQ&msockid=484f7d551e8411f1b36e82125a28847f)

### Ambient Sound

The AR scene includes background ambience to create a relaxing countryside atmosphere.

**Audio Source:**  
[Countryside ambience – Chosic MP3](https://www.chosic.com/download-audio/54552/)

---

## Motivation
The inspiration for this AR knick-knack was **Napa Valley, California**, which I visited last summer during my sister’s bachelorette trip. The vineyards and countryside scenery made it a memorable place.

The goal of the project was to recreate a small representation of that memory using augmented reality. Similar to a physical souvenir, the AR knick-knack represents a personal experience that could be placed on a desk or shelf in a virtual environment.

---

## Design
The knick-knack design represents a small **vineyard scene** placed on top of the merge cube.

The scene includes:

- A small house
- A bush representing vineyard vegetation
- A wine barrel
- Grapes
- A wine glass

These objects were chosen because they are commonly associated with vineyards and wine culture in Napa Valley.

Three models were sourced from online asset libraries, while two were created manually. The grapes were generated using **Meshy AI** and then edited in Blender. The wine glass was modeled in Blender by following a short tutorial.

The cube itself also includes **four informational faces**, implemented using world-space UI panels:

- **Location Name:** Napa Valley, California  
- **Weather:** Current temperature retrieved from a weather API  
- **Local Time:** Time in Napa Valley’s time zone  
- **Memory Caption:** A reminder of the trip  

The UI panels were designed with readability in mind by using:

- centered text
- bold fonts
- high contrast colors
- a background panel behind the text

---

## Process
This project was built using several tools and technologies:

- **Unity**
- **Vuforia Engine**
- **C# scripting**
- **Blender**
- **Meshy AI**

The merge cube images were used as a **multi-target tracker** through Vuforia so that the cube can be recognized from multiple angles.

The scene hierarchy was structured so that all AR objects are children of the cube tracker:

Two main scripts were written in C#:

### Weather Script
Retrieves the current temperature using the **Open-Meteo weather API** and updates the weather display periodically.

### Time Script
Displays the local time for Napa Valley using Pacific Time.

The cube face panels were implemented using **TextMeshPro world-space UI**, which allows readable text in AR environments.

---

## Challenges and Future Work

One of the main challenges was learning to work with **Blender**, since I had limited experience with 3D modeling. Creating the wine glass and grapes required following a tutorial and experimenting with modeling tools.

Another challenge was integrating **API data into Unity**, especially retrieving and updating weather data for display on the cube.

If I continued developing this project, I would expand the vineyard scene to make it more realistic. Currently, the environment contains only a few objects, but future improvements could include:

- adding rows of vines instead of a single bush
- creating more detailed vineyard scenery
- adding animated environmental elements
---

## Use of AI and Collaboration

AI tools were used in several parts of the project.

**Cursor IDE** was used while writing C# scripts for features such as weather retrieval and time display.

**Meshy AI** was used to help generate the grape model, which was then modified in Blender.
AI assistance was also used to troubleshoot Unity setup issues and help understand how to integrate APIs with AR elements.

Classmates were also helpful in discussing debugging approaches with the MergeCubes.

