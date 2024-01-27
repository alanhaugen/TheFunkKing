#include "game.h"
#include "core/components/camera.h"
#include "core/components/sprite.h"
#include "core/application.h"

Game::Game()
{
};

void Game::Init()
{
    components.Add(new Camera());

    components.Add(new Sprite("data/throne_room.png",
                              0.0f,
                              0.0f,
                              0.8f,
                              0.8f));

    moodText = new Text("THE KINGS MOOD: 100", 200, 50);
    components.Add(moodText);

    selector = new Text(">", 700 - 30, 300);

    isEntertainerPresent = false;
    timer = Application::GetTime();

    option = 1;
    clowndance = 0.0f;
    isGameOver = false;
};

void Game::Update()
{
    if (timer->TimeSinceStarted() > 2000 && isEntertainerPresent == false)
    {
        entertainer = new Sprite("data/entertainer.png",
                                 600.0f,
                                 100.0f,
                                 0.3f,
                                 0.3f);

        components.Add(entertainer);

        entertainerText = new Text("GIGGLESNORT GARY", 300, 150);
        text1 = new Text("STYLE: SLAPSTICK", 600, 200);
        text2 = new Text("ACCEPT", 700, 300);
        text3 = new Text("REJECT", 700, 400);
        components.Add(entertainerText);
        components.Add(text1);
        components.Add(text2);
        components.Add(text3);
        components.Add(selector);

        isEntertainerPresent = true;

        //delete moodText;
        moodText->Hide();
        moodText = new Text("THE KINGS MOOD: 50", 200, 50);
        components.Add(moodText);
    }

    if (isEntertainerPresent)
    {
        if (option > 1)
        {
            if (input.Pressed(input.Key.W) || input.Pressed(input.Key.UP))
            {
                selector->matrix.Translate(glm::vec3(0.0f, -100.0f, 0.0f));
                option--;
            }
        }
        if (option < 2)
        {
            if (input.Pressed(input.Key.S) || input.Pressed(input.Key.DOWN))
            {
                selector->matrix.Translate(glm::vec3(0.0f, 100.0f, 0.0f));
                option++;
            }
        }
    }
    if (input.Pressed(input.Key.F) || input.Pressed(input.Key.ENTER))
    {
        if (option == 1)
        {
            moodText->Hide();
            moodText = new Text("THE KINGS MOOD: 100", 200, 50);
            components.Add(moodText);
        }
        else if (option == 2)
        {
            moodText->Hide();
            entertainer->Hide();
            moodText = new Text("THE KINGS MOOD: 0", 200, 50);
            components.Add(moodText);
        }

        isGameOver = true;

        entertainerText->Hide();
        selector->Hide();
        text1->Hide();
        text2->Hide();
        text3->Hide();
    }

    if (isGameOver)
    {
        entertainer->matrix.Translate(glm::vec3(cos(clowndance)*2, sin(clowndance)*2, 0));
        clowndance += 0.4f;
    }
};

void Game::UpdateAfterPhysics()
{
};

