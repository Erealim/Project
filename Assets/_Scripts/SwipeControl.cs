﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControl : MonoBehaviour {

    private Vector3 fp;   //Первая позиция касания
    private Vector3 lp;   //Последняя позиция касания
    private float dragDistance;  //Минимальная дистанция для определения свайпа
    private List<Vector3> touchPositions = new List<Vector3>(); //Храним все позиции касания в списке

    void Start()
    {
        dragDistance = Screen.height * 15 / 100; //dragDistance это 15% высоты экрана
    }

    void Update()
    {

        foreach (Touch touch in Input.touches)  //используем цикл для отслеживания больше одного свайпа
        { //должны быть закоментированы, если вы используете списки 
          /*if (touch.phase == TouchPhase.Began) //проверяем первое касание
          {
              fp = touch.position;
              lp = touch.position;

          }*/

            if (touch.phase == TouchPhase.Moved) //добавляем касания в список, как только они определены
            {
                touchPositions.Add(touch.position);
            }

            if (touch.phase == TouchPhase.Ended) //проверяем, если палец убирается с экрана
            {
                //lp = touch.position;  //последняя позиция касания. закоментируйте если используете списки
                fp = touchPositions[0]; //получаем первую позицию касания из списка касаний
                lp = touchPositions[touchPositions.Count - 1]; //позиция последнего касания

                //проверяем дистанцию перемещения больше чем 20% высоты экрана
                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {//это перемещение
                 //проверяем, перемещение было вертикальным или горизонтальным 
                    if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {   //Если горизонтальное движение больше, чем вертикальное движение ...
                        if ((lp.x > fp.x))  //Если движение было вправо
                        {   //Свайп вправо
                            Debug.Log("Right Swipe");
                        }
                        else
                        {   //Свайп влево
                            Debug.Log("Left Swipe");
                        }
                    }                  
                }
            }
            else
            {   //Это ответвление, как расстояние перемещения составляет менее 20% от высоты экрана

            }
        }
    }
}
