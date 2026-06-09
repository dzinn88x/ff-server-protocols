using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001609 RID: 5641
	[Token(Token = "0x2001609")]
	public class DrawLineManager : MonoSingleton<DrawLineManager>
	{
		// Token: 0x06006518 RID: 25880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006518")]
		[Address(RVA = "0x160987C", Offset = "0x160987C", VA = "0x7BBBE0987C", Slot = "5")]
		public override void Init()
		{
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006519")]
		[Address(RVA = "0x1609F4C", Offset = "0x1609F4C", VA = "0x7BBBE09F4C")]
		private void Update()
		{
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651A")]
		[Address(RVA = "0x160B310", Offset = "0x160B310", VA = "0x7BBBE0B310")]
		private void ResetLine()
		{
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651B")]
		[Address(RVA = "0x160B218", Offset = "0x160B218", VA = "0x7BBBE0B218")]
		public void Undo()
		{
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651C")]
		[Address(RVA = "0x160B3D0", Offset = "0x160B3D0", VA = "0x7BBBE0B3D0")]
		private void ResycleStack()
		{
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651D")]
		[Address(RVA = "0x160B530", Offset = "0x160B530", VA = "0x7BBBE0B530")]
		private void InstantiateLine()
		{
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651E")]
		[Address(RVA = "0x160A1E0", Offset = "0x160A1E0", VA = "0x7BBBE0A1E0")]
		private void ProcessDraw(bool MouseHoverOnButton = false)
		{
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651F")]
		[Address(RVA = "0x160ACA8", Offset = "0x160ACA8", VA = "0x7BBBE0ACA8")]
		private void ProcessDrawArrowLine(bool MouseHoverOnButton = false)
		{
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006520")]
		[Address(RVA = "0x160A4A4", Offset = "0x160A4A4", VA = "0x7BBBE0A4A4")]
		private void ProcessLine(bool MouseHoverOnButton = false)
		{
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006521")]
		[Address(RVA = "0x160A7B8", Offset = "0x160A7B8", VA = "0x7BBBE0A7B8")]
		private void ProcessDrawCircle(bool MouseHoverOnButton = false)
		{
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006522")]
		[Address(RVA = "0x160B9EC", Offset = "0x160B9EC", VA = "0x7BBBE0B9EC")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006523")]
		[Address(RVA = "0x160B9F8", Offset = "0x160B9F8", VA = "0x7BBBE0B9F8")]
		public void Clear(bool resetstate = true)
		{
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006524")]
		[Address(RVA = "0x160BB90", Offset = "0x160BB90", VA = "0x7BBBE0BB90")]
		public DrawLineManager()
		{
		}

		// Token: 0x04008351 RID: 33617
		[Token(Token = "0x4008351")]
		[FieldOffset(Offset = "0x18")]
		public List<Rect> EditorUIRectList;

		// Token: 0x04008352 RID: 33618
		[Token(Token = "0x4008352")]
		[FieldOffset(Offset = "0x20")]
		public MapEditorType CurrentMapEditorType;

		// Token: 0x04008353 RID: 33619
		[Token(Token = "0x4008353")]
		[FieldOffset(Offset = "0x24")]
		public bool IsMapOpen;

		// Token: 0x04008354 RID: 33620
		[Token(Token = "0x4008354")]
		[FieldOffset(Offset = "0x25")]
		public bool OpenDrawFunction;

		// Token: 0x04008355 RID: 33621
		[Token(Token = "0x4008355")]
		[FieldOffset(Offset = "0x28")]
		private int MaxCtrlZCount;

		// Token: 0x04008356 RID: 33622
		[Token(Token = "0x4008356")]
		[FieldOffset(Offset = "0x2C")]
		private int ZPostion;

		// Token: 0x04008357 RID: 33623
		[Token(Token = "0x4008357")]
		[FieldOffset(Offset = "0x30")]
		private Color CurrentColor;

		// Token: 0x04008358 RID: 33624
		[Token(Token = "0x4008358")]
		[FieldOffset(Offset = "0x40")]
		private LineRenderer lineRenderer;

		// Token: 0x04008359 RID: 33625
		[Token(Token = "0x4008359")]
		[FieldOffset(Offset = "0x48")]
		private Transform LinesTrans;

		// Token: 0x0400835A RID: 33626
		[Token(Token = "0x400835A")]
		[FieldOffset(Offset = "0x50")]
		private Camera Camera;

		// Token: 0x0400835B RID: 33627
		[Token(Token = "0x400835B")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 position;

		// Token: 0x0400835C RID: 33628
		[Token(Token = "0x400835C")]
		[FieldOffset(Offset = "0x64")]
		private int index;

		// Token: 0x0400835D RID: 33629
		[Token(Token = "0x400835D")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_StartPos;

		// Token: 0x0400835E RID: 33630
		[Token(Token = "0x400835E")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 m_EndPos;

		// Token: 0x0400835F RID: 33631
		[Token(Token = "0x400835F")]
		[FieldOffset(Offset = "0x80")]
		private int LengthOfLineRenderer;

		// Token: 0x04008360 RID: 33632
		[Token(Token = "0x4008360")]
		[FieldOffset(Offset = "0x88")]
		private LineRenderer m_CurrentlLine;

		// Token: 0x04008361 RID: 33633
		[Token(Token = "0x4008361")]
		[FieldOffset(Offset = "0x90")]
		public List<GameObject> LineList;

		// Token: 0x04008362 RID: 33634
		[Token(Token = "0x4008362")]
		[FieldOffset(Offset = "0x98")]
		public Stack<GameObject> LinesUndo;

		// Token: 0x04008363 RID: 33635
		[Token(Token = "0x4008363")]
		[FieldOffset(Offset = "0xA0")]
		private int pointCount;

		// Token: 0x04008364 RID: 33636
		[Token(Token = "0x4008364")]
		[FieldOffset(Offset = "0xA4")]
		private float radius;

		// Token: 0x04008365 RID: 33637
		[Token(Token = "0x4008365")]
		[FieldOffset(Offset = "0xA8")]
		private float angle;

		// Token: 0x04008366 RID: 33638
		[Token(Token = "0x4008366")]
		[FieldOffset(Offset = "0xB0")]
		private List<Vector3> points;

		// Token: 0x04008367 RID: 33639
		[Token(Token = "0x4008367")]
		[FieldOffset(Offset = "0xB8")]
		private LineRenderer m_HeadLineRendererLeft;

		// Token: 0x04008368 RID: 33640
		[Token(Token = "0x4008368")]
		[FieldOffset(Offset = "0xC0")]
		private LineRenderer m_HeadLineRendererRight;
	}
}
