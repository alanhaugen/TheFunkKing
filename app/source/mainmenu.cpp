#include <core/application.h>
#include "mainmenu.h"

const int CREDITS = 3;

MainMenu::MainMenu()
{
};

void MainMenu::Init()
{
    components.Add(new Camera());

    text = new Text("THE KINGS MOOD", 400, 100);

    option1 = new Text("START GAME", 500, 300);
    option2 = new Text("DIFFICULTY: NORMAL", 500, 400);
    option3 = new Text("CREDITS", 500, 500);
    option4 = new Text("FULLSCREEN", 500, 600);
    option5 = new Text("QUIT", 500, 700);

    selector = new Text(">", 470, 300);

    components.Add(text);

    components.Add(option1);
    components.Add(option2);
    components.Add(option3);
    components.Add(option4);
    components.Add(option5);

    components.Add(selector);

    option = 1;
};

void MainMenu::Update()
{
    if (option > 1)
    {
        if (input.Pressed(input.Key.W) || input.Pressed(input.Key.UP))
        {
            selector->matrix.Translate(glm::vec3(0.0f, -100.0f, 0.0f));
            option--;
        }
    }
    if (option < 5)
    {
        if (input.Pressed(input.Key.S) || input.Pressed(input.Key.DOWN))
        {
            selector->matrix.Translate(glm::vec3(0.0f, 100.0f, 0.0f));
            option++;
        }
    }

    if (input.Pressed(input.Key.F) || input.Pressed(input.Key.ENTER))
    {
        if (option == 1)
        {
            Application::NextScene();
        }
        else if (option == 2)
        {
            Application::LoadScene(CREDITS);
            //Application::fullscreen = true;
        }
        else if (option == 4)
        {
            Application::fullscreen = true;
        }
        else if (option == 5)
        {
            Application::Quit();
        }
    }
};

void MainMenu::UpdateAfterPhysics()
{
};

