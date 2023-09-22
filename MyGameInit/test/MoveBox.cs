using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Physics;

namespace MyGameInit.test
{
    public class MoveBox : SyncScript
    {
        public float Speed {get; set; } = 1.0f;
        public float jumpForce = 6;
        private CharacterComponent controller;
        

        public override void Start()
        {
            controller = Entity.Get<CharacterComponent>();
        }

        public override void Update()
        {
            // add gravidade

            /*var rb = Entity.Get<RigidbodyComponent>();
            rb.Gravity = new Vector3(0, Gravity, 0);*/

            // obtem entrada do teclado
            var keyboard = Input.Keyboard;

            var movement = new Vector3();

            //var rotation = Entity.Local.Transform.Rotation;

            if (keyboard.IsKeyDown(Keys.I))
            {
                //movement.X -= Speed;
                controller.SetVelocity(new Vector3(Speed, 0, 0));
            }

            else if (keyboard.IsKeyDown(Keys.K))
            {
                //movement.Z -= Speed;
                controller.SetVelocity(new Vector3(-Speed, 0, 0));
            }

            else if (keyboard.IsKeyDown(Keys.J))
            {
                //movement.X += Speed;
                controller.SetVelocity(new Vector3(0, 0, Speed));
                //rotation *= Quartenion.RotationY(Speed * (float)Game.UpdateTime.Elapsed.TotalSeconds);
                //Entities.Local.Transform.Rotation = rotation;
            }

            else if (keyboard.IsKeyDown(Keys.L))
            {
                //movement.Z += Speed;
                controller.SetVelocity(new Vector3(0, 0, -Speed));

            }

            else 
            {
                controller.SetVelocity(Vector3.Zero);
            }

            if (Input.IsKeyDown(Keys.Space) && controller.IsGrounded == true)
            {
                controller.Jump(new Vector3(0, jumpForce, 0));
            }

            // aplica mov ao cubo
            //Entity.Transform.Position += movement * (float)Game.UpdateTime.Elapsed.TotalSeconds;
        }
    }
}
