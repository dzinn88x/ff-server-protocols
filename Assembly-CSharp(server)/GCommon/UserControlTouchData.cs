using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EFD RID: 3837
	[Token(Token = "0x2000EFD")]
	public class UserControlTouchData
	{
		// Token: 0x060035D1 RID: 13777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D1")]
		[Address(RVA = "0x2246714", Offset = "0x2246714", VA = "0x7BBCA46714")]
		public UserControlTouchData(float actually_move_dist)
		{
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D2")]
		[Address(RVA = "0x2247C48", Offset = "0x2247C48", VA = "0x7BBCA47C48")]
		public void OnBegin(Vector3 startPos)
		{
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D3")]
		[Address(RVA = "0x2247D84", Offset = "0x2247D84", VA = "0x7BBCA47D84")]
		public void OnEnd()
		{
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D4")]
		[Address(RVA = "0x2247F4C", Offset = "0x2247F4C", VA = "0x7BBCA47F4C")]
		public void OnStationary(Vector3 curPos)
		{
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D5")]
		[Address(RVA = "0x2247E50", Offset = "0x2247E50", VA = "0x7BBCA47E50")]
		public void OnMove(Vector3 lastPos, Vector3 curPos)
		{
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x000103F8 File Offset: 0x0000E5F8
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x22481FC", Offset = "0x22481FC", VA = "0x7BBCA481FC")]
		public bool HaveCachedTouchPos()
		{
			return default(bool);
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x00010410 File Offset: 0x0000E610
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x2248D5C", Offset = "0x2248D5C", VA = "0x7BBCA48D5C")]
		public bool IsTouched()
		{
			return default(bool);
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00010428 File Offset: 0x0000E628
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x2248350", Offset = "0x2248350", VA = "0x7BBCA48350")]
		public Vector3 GetCachedTouchPos()
		{
			return default(Vector3);
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x2247F58", Offset = "0x2247F58", VA = "0x7BBCA47F58")]
		public void ClearTouchInfo()
		{
		}

		// Token: 0x0400491E RID: 18718
		[Token(Token = "0x400491E")]
		[FieldOffset(Offset = "0x10")]
		public UserControlTouchInfo TouchInfo;

		// Token: 0x0400491F RID: 18719
		[Token(Token = "0x400491F")]
		[FieldOffset(Offset = "0x18")]
		public UserControlTouchInfo LastTouchInfo;

		// Token: 0x04004920 RID: 18720
		[Token(Token = "0x4004920")]
		[FieldOffset(Offset = "0x20")]
		private bool m_IsTouched;

		// Token: 0x04004921 RID: 18721
		[Token(Token = "0x4004921")]
		[FieldOffset(Offset = "0x21")]
		private bool m_IsActuallyMoved;

		// Token: 0x04004922 RID: 18722
		[Token(Token = "0x4004922")]
		[FieldOffset(Offset = "0x22")]
		private bool m_IsInBegin;

		// Token: 0x04004923 RID: 18723
		[Token(Token = "0x4004923")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 m_StartScreenPos;

		// Token: 0x04004924 RID: 18724
		[Token(Token = "0x4004924")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_CurrentScreenPos;

		// Token: 0x04004925 RID: 18725
		[Token(Token = "0x4004925")]
		[FieldOffset(Offset = "0x3C")]
		private float m_ActuallyMovedDistance;

		// Token: 0x04004926 RID: 18726
		[Token(Token = "0x4004926")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 m_CachedScreenPos;
	}
}
