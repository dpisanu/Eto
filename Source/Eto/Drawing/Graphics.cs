using System;
using System.Collections.Generic;

namespace Eto.Drawing
{
	/// <summary>
	/// Platform handler interface for the <see cref="Graphics"/> class
	/// </summary>
	public interface IGraphics : IInstanceWidget
	{
		PixelOffsetMode PixelOffsetMode { get; set; }

		/// <summary>
		/// Creates the graphics object for drawing on the specified <paramref name="image"/>
		/// </summary>
		/// <param name="image">Image to perform drawing operations on</param>
		void CreateFromImage (Bitmap image);

		/// <summary>
		/// Draws a line with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Color for the outline</param>
		/// <param name="startx">X co-ordinate of the starting point</param>
		/// <param name="starty">Y co-ordinate of the starting point</param>
		/// <param name="endx">X co-ordinate of the ending point</param>
		/// <param name="endy">Y co-ordinate of the ending point</param>
		void DrawLine (Color color, float startx, float starty, float endx, float endy);

		/// <summary>
		/// Draws a rectangle outline
		/// </summary>
		/// <param name="color">Color for the outline</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		/// <param name="width">Width of the rectangle</param>
		/// <param name="height">Height of the rectangle</param>
		void DrawRectangle (Color color, float x, float y, float width, float height);

		/// <summary>
		/// Fills a rectangle with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		/// <param name="width">Width of the rectangle</param>
		/// <param name="height">Height of the rectangle</param>
		void FillRectangle (Color color, float x, float y, float width, float height);

		/// <summary>
		/// Fills an ellipse with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="x">X co-ordinate of the left side of the ellipse</param>
		/// <param name="y">Y co-ordinate of the top of the ellipse</param>
		/// <param name="width">Width of the ellipse</param>
		/// <param name="height">Height of the ellipse</param>
		void FillEllipse (Color color, float x, float y, float width, float height);

		/// <summary>
		/// Draws an outline of an ellipse with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Line color</param>
		/// <param name="x">X co-ordinate of the left side of the ellipse</param>
		/// <param name="y">Y co-ordinate of the top of the ellipse</param>
		/// <param name="width">Width of the ellipse</param>
		/// <param name="height">Height of the ellipse</param>
		void DrawEllipse (Color color, float x, float y, float width, float height);

		/// <summary>
		/// Draws an arc with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Color of the arc</param>
		/// <param name="x">X co-ordinate of the upper left corner of the arc</param>
		/// <param name="y">Y co-ordinate of the upper left corner of the arc</param>
		/// <param name="width">Width of the arc</param>
		/// <param name="height">Height of the arc</param>
		/// <param name="startAngle">Elliptical (skewed) angle in degrees from the x-axis to the starting point of the arc</param>
		/// <param name="sweepAngle">Angle in degrees from the <paramref name="startAngle"/> to the ending point of the arc</param>
		void DrawArc (Color color, float x, float y, float width, float height, float startAngle, float sweepAngle);

		/// <summary>
		/// Fills a pie with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="x">X co-ordinate of the upper left corner of the pie</param>
		/// <param name="y">Y co-ordinate of the upper left corner of the pie</param>
		/// <param name="width">Width of the pie</param>
		/// <param name="height">Height of the pie</param>
		/// <param name="startAngle">Elliptical (skewed) angle in degrees from the x-axis to the starting point of the pie</param>
		/// <param name="sweepAngle">Angle in degrees from the <paramref name="startAngle"/> to the ending point of the pie</param>
		void FillPie (Color color, float x, float y, float width, float height, float startAngle, float sweepAngle);

		/// <summary>
		/// Fills the specified <paramref name="path"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="path">Path to fill</param>
		void FillPath (Color color, GraphicsPath path);

		/// <summary>
		/// Draws the specified <paramref name="path"/>
		/// </summary>
		/// <param name="color">Draw color</param>
		/// <param name="path">Path to draw</param>
		void DrawPath (Color color, GraphicsPath path);

		/// <summary>
		/// Draws the specified <paramref name="image"/> at a location with no scaling
		/// </summary>
		/// <param name="image">Image to draw</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		void DrawImage (Image image, float x, float y);

		/// <summary>
		/// Draws the specified <paramref name="image"/> in a rectangle
		/// </summary>
		/// <remarks>
		/// This will scale the image to the specified width and height using the <see cref="ImageInterpolation"/> mode
		/// </remarks>
		/// <param name="image">Image to draw</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		/// <param name="width">Destination width of the image to draw</param>
		/// <param name="height">Destination height of the image to draw</param>
		void DrawImage (Image image, float x, float y, float width, float height);

		/// <summary>
		/// Draws the <paramref name="source"/> portion of an <paramref name="image"/>, scaling to the specified <paramref name="destination"/>
		/// </summary>
		/// <param name="image">Image to draw</param>
		/// <param name="source">Source rectangle of the image portion to draw</param>
		/// <param name="destination">Destination rectangle of where to draw the portion</param>
		void DrawImage (Image image, RectangleF source, RectangleF destination);

		/// <summary>
		/// Draws text with the specified <paramref name="font"/>, <paramref name="color"/> and location
		/// </summary>
		/// <param name="font">Font to draw the text with</param>
		/// <param name="color">Color of the text</param>
		/// <param name="x">X co-ordinate of where to start drawing the text</param>
		/// <param name="y">Y co-ordinate of where to start drawing the text</param>
		/// <param name="text">Text string to draw</param>
		void DrawText (Font font, Color color, float x, float y, string text);

		/// <summary>
		/// Measures the string with the given <paramref name="font"/>
		/// </summary>
		/// <param name="font">Font to measure with</param>
		/// <param name="text">Text string to measure</param>
		/// <returns>Size representing the dimensions of the entire text would take to draw given the specified <paramref name="font"/></returns>
		SizeF MeasureString (Font font, string text);

		/// <summary>
		/// Flushes the drawing (for some platforms)
		/// </summary>
		/// <remarks>
		/// Flushing the drawing will force any undrawn changes to be shown to the user.  Typically when you are doing
		/// a lot of drawing, you may want to flush the changed periodically so that the user does not think the UI is unresponsive.
		/// </remarks>
		void Flush ();

		/// <summary>
		/// Gets or sets a value indicating that drawing operations will use antialiasing
		/// </summary>
		bool Antialias { get; set; }

		/// <summary>
		/// Gets or sets the interpolation mode for drawing images
		/// </summary>
		ImageInterpolation ImageInterpolation { get; set; }

		/// <summary>
		/// Gets a value indicating the graphics sub-system is a retained system (e.g. WPF)
		/// </summary>
		/// <remarks>
		/// Retained mode systems may have different behaviour characteristics, which may impact how often the screen is updated
		/// or other code.
		/// </remarks>
		bool IsRetained { get; }
	}

	/// <summary>
	/// Graphics context object for drawing operations
	/// </summary>
	/// <remarks>
	/// This class allows you to draw on either a <see cref="Bitmap"/> or a <see cref="T:Eto.Forms.Drawable"/> control.
	/// </remarks>
	public class Graphics : InstanceWidget
	{
		new IGraphics Handler { get { return (IGraphics)base.Handler; } }

		/// <summary>
		/// Initializes a new instance of the Graphics class with the specified platform <paramref name="handler"/>
		/// </summary>
		/// <param name="generator">Generator for this instance</param>
		/// <param name="handler">Platform handler to use for this instance</param>
		public Graphics (Generator generator, IGraphics handler) : base(generator, handler)
		{
		}

		/// <summary>
		/// Initializes a new instance of the Generator class to draw on the given <paramref name="image"/>
		/// </summary>
		/// <param name="image">Image to draw on using this graphics context</param>
		public Graphics (Bitmap image)
			: this(image.Generator, image)
		{
		}

		/// <summary>
		/// Initializes a new instance of the Generator class to draw on the given <paramref name="image"/>
		/// </summary>
		/// <param name="generator">Generator to create this graphics context for</param>
		/// <param name="image">Image to draw on using this graphics context</param>
		public Graphics (Generator generator, Bitmap image)
			: base (generator, typeof (IGraphics), false)
		{
			Handler.CreateFromImage (image);
			Initialize ();
		}

		/// <summary>
		/// Initializes a new instance of the Graphics with the specified handler type.
		/// Allows derived types to change the handler.
		/// </summary>
		/// <param name="generator">Generator to create this graphics context for</param>
		/// <param name="handlerType"></param>
		protected Graphics (Generator generator, Type handlerType)
			: base(generator, handlerType)
		{
		}

		/// <summary>
		/// Draws a line with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Color for the outline</param>
		/// <param name="start">Starting location</param>
		/// <param name="end">Ending location</param>
		public void DrawLine (Color color, PointF start, PointF end)
		{
			Handler.DrawLine (color, start.X, start.Y, end.X, end.Y);
		}

		/// <summary>
		/// Draws a line with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Color for the outline</param>
		/// <param name="startx">X co-ordinate of the starting point</param>
		/// <param name="starty">Y co-ordinate of the starting point</param>
		/// <param name="endx">X co-ordinate of the ending point</param>
		/// <param name="endy">Y co-ordinate of the ending point</param>
		public void DrawLine (Color color, float startx, float starty, float endx, float endy)
		{
			Handler.DrawLine (color, startx, starty, endx, endy);
		}

		/// <summary>
		/// Draws a rectangle
		/// </summary>
		/// <param name="color">Color for the outline</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		/// <param name="width">Width of the rectangle</param>
		/// <param name="height">Height of the rectangle</param>
		public void DrawRectangle (Color color, float x, float y, float width, float height)
		{
			Handler.DrawRectangle (color, x, y, width, height);
		}

		/// <summary>
		/// Draws a rectangle
		/// </summary>
		/// <param name="color">Color for the outline</param>
		/// <param name="rectangle">Where to draw the rectangle</param>
		public void DrawRectangle (Color color, RectangleF rectangle)
		{
			Handler.DrawRectangle (color, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
		}

		/// <summary>
		/// Draws an rectangle with colors on the top/left and bottom/right with the given <paramref name="width"/>
		/// </summary>
		/// <param name="topLeftColor">Color for top/left edges</param>
		/// <param name="bottomRightColor">Color for bottom/right edges</param>
		/// <param name="rectangle">Outside of inset rectangle to draw</param>
		/// <param name="width">Width of the rectangle, in pixels</param>
		public void DrawInsetRectangle (Color topLeftColor, Color bottomRightColor, RectangleF rectangle, int width = 1)
		{
			for (int i = 0; i < width; i++) {
				DrawLine (topLeftColor, rectangle.TopLeft, rectangle.InnerTopRight);
				DrawLine (topLeftColor, rectangle.TopLeft, rectangle.InnerBottomLeft);
				DrawLine (bottomRightColor, rectangle.InnerBottomLeft, rectangle.InnerBottomRight);
				DrawLine (bottomRightColor, rectangle.InnerTopRight, rectangle.InnerBottomRight);
				rectangle.Inflate (-1, -1);
			}
		}

		/// <summary>
		/// Fills a rectangle with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		/// <param name="width">Width of the rectangle</param>
		/// <param name="height">Height of the rectangle</param>
		public void FillRectangle (Color color, float x, float y, float width, float height)
		{
			Handler.FillRectangle (color, x, y, width, height);
		}

		/// <summary>
		/// Fills a rectangle with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="rectangle">Location for the rectangle</param>
		public void FillRectangle (Color color, RectangleF rectangle)
		{
			Handler.FillRectangle (color, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
		}

		/// <summary>
		/// Fills the specified <paramref name="rectangles"/>
		/// </summary>
		/// <param name="color">Color to fill the rectangles</param>
		/// <param name="rectangles">Enumeration of rectangles to fill</param>
		public void FillRectangles (Color color, IEnumerable<RectangleF> rectangles)
		{
			foreach (var rectangle in rectangles) {
				Handler.FillRectangle (color, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
			}
		}

		/// <summary>
		/// Fills an ellipse with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="rectangle">Location for the ellipse</param>
		public void FillEllipse (Color color, RectangleF rectangle)
		{
			Handler.FillEllipse (color, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
		}

		/// <summary>
		/// Fills an ellipse with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		/// <param name="width">Width of the ellipse</param>
		/// <param name="height">Height of the ellipse</param>
		public void FillEllipse (Color color, float x, float y, float width, float height)
		{
			Handler.FillEllipse (color, x, y, width, height);
		}

		/// <summary>
		/// Draws an ellipse outline with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Color to outline the ellipse</param>
		/// <param name="rectangle">Location for the ellipse</param>
		public void DrawEllipse (Color color, RectangleF rectangle)
		{
			Handler.DrawEllipse (color, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
		}

		/// <summary>
		/// Draws an ellipse with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		/// <param name="width">Width of the ellipse</param>
		/// <param name="height">Height of the ellipse</param>
		public void DrawEllipse (Color color, float x, float y, float width, float height)
		{
			Handler.DrawEllipse (color, x, y, width, height);
		}

		/// <summary>
		/// Draws an arc with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Color of the arc</param>
		/// <param name="rectangle">Location of the arc</param>
		/// <param name="startAngle">Elliptical (skewed) angle in degrees from the x-axis to the starting point of the arc</param>
		/// <param name="sweepAngle">Angle in degrees from the <paramref name="startAngle"/> to the ending point of the arc</param>
		public void DrawArc (Color color, RectangleF rectangle, float startAngle, float sweepAngle)
		{
			Handler.DrawArc (color, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, startAngle, sweepAngle);
		}

		/// <summary>
		/// Draws an arc with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Color of the arc</param>
		/// <param name="x">X co-ordinate of the upper left corner of the arc</param>
		/// <param name="y">Y co-ordinate of the upper left corner of the arc</param>
		/// <param name="width">Width of the arc</param>
		/// <param name="height">Height of the arc</param>
		/// <param name="startAngle">Elliptical (skewed) angle in degrees from the x-axis to the starting point of the arc</param>
		/// <param name="sweepAngle">Angle in degrees from the <paramref name="startAngle"/> to the ending point of the arc</param>
		public void DrawArc (Color color, float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			Handler.DrawArc (color, x, y, width, height, startAngle, sweepAngle);
		}

		/// <summary>
		/// Fills a pie with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="rectangle">Location of the pie</param>
		/// <param name="startAngle">Elliptical (skewed) angle in degrees from the x-axis to the starting point of the pie</param>
		/// <param name="sweepAngle">Angle in degrees from the <paramref name="startAngle"/> to the ending point of the pie</param>
		public void FillPie (Color color, RectangleF rectangle, float startAngle, float sweepAngle)
		{
			Handler.FillPie (color, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, startAngle, sweepAngle);
		}

		/// <summary>
		/// Fills a pie with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="x">X co-ordinate of the upper left corner of the pie</param>
		/// <param name="y">Y co-ordinate of the upper left corner of the pie</param>
		/// <param name="width">Width of the pie</param>
		/// <param name="height">Height of the pie</param>
		/// <param name="startAngle">Elliptical (skewed) angle in degrees from the x-axis to the starting point of the pie</param>
		/// <param name="sweepAngle">Angle in degrees from the <paramref name="startAngle"/> to the ending point of the pie</param>
		public void FillPie (Color color, float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			Handler.FillPie (color, x, y, width, height, startAngle, sweepAngle);
		}

		/// <summary>
		/// Fills a polygon defined by <paramref name="points"/> with the specified <paramref name="color"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="points">Points of the polygon</param>
		public void FillPolygon (Color color, params PointF[] points)
		{
			var path = new GraphicsPath (Generator);
			path.AddLines (points);
			FillPath (color, path);
		}

		/// <summary>
		/// Draws a polygon with the specified <paramref name="points"/>
		/// </summary>
		/// <param name="color">Color to draw the polygon lines</param>
		/// <param name="points">Points of the polygon</param>
		public void DrawPolygon (Color color, params PointF[] points)
		{
			var path = new GraphicsPath (Generator);
			path.AddLines (points);
			DrawPath (color, path);
		}

		/// <summary>
		/// Draws the specified <paramref name="path"/>
		/// </summary>
		/// <param name="color">Draw color</param>
		/// <param name="path">Path to draw</param>
		public void DrawPath (Color color, GraphicsPath path)
		{
			Handler.DrawPath (color, path);
		}

		/// <summary>
		/// Fills the specified <paramref name="path"/>
		/// </summary>
		/// <param name="color">Fill color</param>
		/// <param name="path">Path to fill</param>
		public void FillPath (Color color, GraphicsPath path)
		{
			Handler.FillPath (color, path);
		}

		/// <summary>
		/// Draws the specified <paramref name="image"/> at a location with no scaling
		/// </summary>
		/// <param name="image">Image to draw</param>
		/// <param name="location">Location to draw the image</param>
		public void DrawImage (Image image, PointF location)
		{
			Handler.DrawImage (image, location.X, location.Y);
		}

		/// <summary>
		/// Draws the specified <paramref name="image"/> at a location with no scaling
		/// </summary>
		/// <param name="image">Image to draw</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		public void DrawImage (Image image, float x, float y)
		{
			Handler.DrawImage (image, x, y);
		}

		/// <summary>
		/// Draws the specified <paramref name="image"/> in a rectangle
		/// </summary>
		/// <remarks>
		/// This will scale the image to the specified width and height using the <see cref="ImageInterpolation"/> mode
		/// </remarks>
		/// <param name="image">Image to draw</param>
		/// <param name="x">X co-ordinate</param>
		/// <param name="y">Y co-ordinate</param>
		/// <param name="width">Destination width of the image to draw</param>
		/// <param name="height">Destination height of the image to draw</param>
		public void DrawImage (Image image, float x, float y, float width, float height)
		{
			Handler.DrawImage (image, x, y, width, height);
		}

		/// <summary>
		/// Draws the specified <paramref name="image"/> in a rectangle
		/// </summary>
		/// <remarks>
		/// This will scale the image to the specified width and height using the <see cref="ImageInterpolation"/> mode
		/// </remarks>
		/// <param name="image">Image to draw</param>
		/// <param name="rectangle">Where to draw the image</param>
		public void DrawImage (Image image, RectangleF rectangle)
		{
			Handler.DrawImage (image, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
		}

		/// <summary>
		/// Draws the <paramref name="source"/> portion of an <paramref name="image"/>, scaling to the specified <paramref name="destination"/>
		/// </summary>
		/// <param name="image">Image to draw</param>
		/// <param name="source">Source rectangle of the image portion to draw</param>
		/// <param name="destination">Destination rectangle of where to draw the portion</param>
		public void DrawImage (Image image, RectangleF source, PointF destination)
		{
			Handler.DrawImage (image, source, new RectangleF (destination, source.Size));
		}

		/// <summary>
		/// Draws the <paramref name="source"/> portion of an <paramref name="image"/>, scaling to the specified <paramref name="destination"/>
		/// </summary>
		/// <param name="image">Image to draw</param>
		/// <param name="source">Source rectangle of the image portion to draw</param>
		/// <param name="destination">Destination rectangle of where to draw the portion</param>
		public void DrawImage (Image image, RectangleF source, RectangleF destination)
		{
			Handler.DrawImage (image, source, destination);
		}

		/// <summary>
		/// Draws text with the specified <paramref name="font"/>, <paramref name="color"/> and location
		/// </summary>
		/// <param name="font">Font to draw the text with</param>
		/// <param name="color">Color of the text</param>
		/// <param name="x">X co-ordinate of where to start drawing the text</param>
		/// <param name="y">Y co-ordinate of where to start drawing the text</param>
		/// <param name="text">Text string to draw</param>
		public void DrawText (Font font, Color color, float x, float y, string text)
		{
			Handler.DrawText (font, color, x, y, text);
		}

		/// <summary>
		/// Draws text with the specified <paramref name="font"/>, <paramref name="color"/> and location
		/// </summary>
		/// <param name="font">Font to draw the text with</param>
		/// <param name="color">Color of the text</param>
		/// <param name="location">Location of where to start drawing the text</param>
		/// <param name="text">Text string to draw</param>
		public void DrawText (Font font, Color color, PointF location, string text)
		{
			Handler.DrawText (font, color, location.X, location.Y, text);
		}

		/// <summary>
		/// Measures the string with the given <paramref name="font"/>
		/// </summary>
		/// <param name="font">Font to measure with</param>
		/// <param name="text">Text string to measure</param>
		/// <returns>Size representing the dimensions of the entire text would take to draw given the specified <paramref name="font"/></returns>
		public SizeF MeasureString (Font font, string text)
		{
			return Handler.MeasureString (font, text);
		}

		/// <summary>
		/// Gets or sets a value indicating that drawing operations will use antialiasing
		/// </summary>
		public bool Antialias
		{
			get { return Handler.Antialias; }
			set { Handler.Antialias = value; }
		}

		/// <summary>
		/// Gets or sets the interpolation mode for drawing images
		/// </summary>
		public ImageInterpolation ImageInterpolation
		{
			get { return Handler.ImageInterpolation; }
			set { Handler.ImageInterpolation = value; }
		}

		/// <summary>
		/// Gets or sets the offset mode for drawing operations
		/// </summary>
		public PixelOffsetMode PixelOffsetMode
		{
			get { return Handler.PixelOffsetMode; }
			set { Handler.PixelOffsetMode = value; }
		}

		/// <summary>
		/// Gets a value indicating the graphics sub-system is a retained system (e.g. WPF)
		/// </summary>
		/// <remarks>
		/// Retained mode systems may have different behaviour characteristics, which may impact how often the screen is updated
		/// or other code.
		/// </remarks>
		public bool IsRetained
		{
			get { return Handler.IsRetained; }
		}

		/// <summary>
		/// Flushes the drawing (for some platforms)
		/// </summary>
		/// <remarks>
		/// Flushing the drawing will force any undrawn changes to be shown to the user.  Typically when you are doing
		/// a lot of drawing, you may want to flush the changed periodically so that the user does not think the UI is unresponsive.
		/// 
		/// Some platforms may not have the concept of flushing the graphics, so this would do nothing
		/// </remarks>
		public void Flush ()
		{
			Handler.Flush ();
		}

		#region Obsolete

		/// <summary>
		/// Draws the <paramref name="icon"/> at the specified location and size. Obsolete. Use <see cref="DrawImage(Image, RectangleF)"/> instead.
		/// </summary>
		/// <param name="icon">Icon to draw</param>
		/// <param name="rectangle">Where to draw the icon</param>
		[Obsolete("Use DrawImage instead")]
		public void DrawIcon (Icon icon, RectangleF rectangle)
		{
			Handler.DrawImage (icon, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
		}
		
		/// <summary>
		/// Draws the <paramref name="icon"/> at the specified location and size. Obsolete. Use <see cref="DrawImage(Image, float, float, float, float)"/> instead.
		/// </summary>
		/// <param name="icon">Icon to draw</param>
		/// <param name="x">X co-ordinate of the location to draw the icon</param>
		/// <param name="y">Y co-ordinate of the location to draw the icon</param>
		/// <param name="width">Destination width of the icon</param>
		/// <param name="height">Destination height of the icon</param>
		[Obsolete("Use DrawImage instead")]
		public void DrawIcon (Icon icon, float x, float y, float width, float height)
		{
			Handler.DrawImage (icon, x, y, width, height);
		}

		#endregion
	}
}
