using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EF6 RID: 3830
	[Token(Token = "0x2000EF6")]
	public class Grid2D<T> where T : GridValueBase, new()
	{
		// Token: 0x060035AD RID: 13741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AD")]
		public Grid2D(Vector3 pos, float length, float width, float grid_length_size, float grid_width_size)
		{
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AE")]
		public Grid2D(Vector3 leftBottom, Vector3 rightTop, float grid_length_size, float grid_width_size)
		{
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035AF")]
		public T GetValue(Vector3 pos)
		{
			return null;
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B0")]
		public List<T> GetValusArroundPosition(Vector3 pos, int radius, [Optional] List<T> resultList)
		{
			return null;
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B1")]
		public List<T> GetValuesArroundIndex(int index, int radius, List<T> resultList)
		{
			return null;
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00010368 File Offset: 0x0000E568
		[Token(Token = "0x60035B2")]
		public Vector3 GetGridCoordinateByIndex(int index)
		{
			return default(Vector3);
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B3")]
		public void SetValue(Vector3 pos, T value)
		{
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B4")]
		public T GetValue(int index)
		{
			return null;
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B5")]
		public void SetValue(int index, T value)
		{
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00010380 File Offset: 0x0000E580
		[Token(Token = "0x60035B6")]
		public Vector3 GetGridPos(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00010398 File Offset: 0x0000E598
		[Token(Token = "0x60035B7")]
		public Vector3 GetGridPosByCoordinate(Vector3 coordinate)
		{
			return default(Vector3);
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Token(Token = "0x60035B8")]
		private int GetIndexByXZ(Vector3 pos)
		{
			return 0;
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B9")]
		public void Destroy()
		{
		}

		// Token: 0x040048CC RID: 18636
		[Token(Token = "0x40048CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Rectangle2D m_Shape;

		// Token: 0x040048CD RID: 18637
		[Token(Token = "0x40048CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float m_HalfLength;

		// Token: 0x040048CE RID: 18638
		[Token(Token = "0x40048CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float m_HalfWidth;

		// Token: 0x040048CF RID: 18639
		[Token(Token = "0x40048CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_ColumnCount;

		// Token: 0x040048D0 RID: 18640
		[Token(Token = "0x40048D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_RowCount;

		// Token: 0x040048D1 RID: 18641
		[Token(Token = "0x40048D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<int, T> m_Values;

		// Token: 0x040048D2 RID: 18642
		[Token(Token = "0x40048D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_GridCount;

		// Token: 0x040048D3 RID: 18643
		[Token(Token = "0x40048D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector2 m_GridSize;
	}
}
