module FSharpCore.OpenGL

open OpenTK.Graphics.OpenGL
open OpenTK.Mathematics


let OnLoad() = 
    printf "GlWpfControl is now ready"
    GL.Enable(EnableCap.Blend)
    GL.Enable(EnableCap.DepthTest)
    GL.Enable(EnableCap.ScissorTest)

let stopwatch: System.Diagnostics.Stopwatch = System.Diagnostics.Stopwatch.StartNew();

let OnRenderFrame(alpha:float32) =
    let hue:float32 = float32 ((stopwatch.Elapsed.TotalSeconds * float 0.15f) % float 1.0f)
    let c = Color4.FromHsv(new Vector4(alpha * hue, alpha * 0.75f, alpha * 0.75f, alpha))
    GL.ClearColor(c)
    GL.Clear(ClearBufferMask.ColorBufferBit)
    GL.Clear(ClearBufferMask.DepthBufferBit)
    GL.LoadIdentity()
    GL.Begin(PrimitiveType.Triangles)

    GL.Color4(Color4.Red)
    GL.Vertex2(0.0f, 0.5f)

    GL.Color4(Color4.Green)
    GL.Vertex2(0.58f, -0.5f)

    GL.Color4(Color4.Blue)
    GL.Vertex2(-0.58f, -0.5f)

    GL.End()
    GL.Finish()