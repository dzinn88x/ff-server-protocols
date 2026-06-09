using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020B3 RID: 8371
	[Token(Token = "0x20020B3")]
	public class UITimeLabelHelper
	{
		// Token: 0x0600BC67 RID: 48231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC67")]
		[Address(RVA = "0x1F53B94", Offset = "0x1F53B94", VA = "0x7BBC753B94")]
		public void Init(params object[] data)
		{
		}

		// Token: 0x0600BC68 RID: 48232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC68")]
		[Address(RVA = "0x1F53CDC", Offset = "0x1F53CDC", VA = "0x7BBC753CDC")]
		public void Update()
		{
		}

		// Token: 0x0600BC69 RID: 48233 RVA: 0x00035400 File Offset: 0x00033600
		[Token(Token = "0x600BC69")]
		[Address(RVA = "0x1F53D1C", Offset = "0x1F53D1C", VA = "0x7BBC753D1C")]
		public float GetSeconds()
		{
			return 0f;
		}

		// Token: 0x0600BC6A RID: 48234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC6A")]
		[Address(RVA = "0x1F53E28", Offset = "0x1F53E28", VA = "0x7BBC753E28")]
		private void UpdateTimeSeconds(int seconds)
		{
		}

		// Token: 0x0600BC6B RID: 48235 RVA: 0x00035418 File Offset: 0x00033618
		[Token(Token = "0x600BC6B")]
		[Address(RVA = "0x1F54114", Offset = "0x1F54114", VA = "0x7BBC754114")]
		public bool IsTimeout()
		{
			return default(bool);
		}

		// Token: 0x0600BC6C RID: 48236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC6C")]
		[Address(RVA = "0x1F541A0", Offset = "0x1F541A0", VA = "0x7BBC7541A0")]
		public void StopTicking()
		{
		}

		// Token: 0x0600BC6D RID: 48237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC6D")]
		[Address(RVA = "0x1F541B4", Offset = "0x1F541B4", VA = "0x7BBC7541B4")]
		public UITimeLabelHelper()
		{
		}

		// Token: 0x0400BCFB RID: 48379
		[Token(Token = "0x400BCFB")]
		[FieldOffset(Offset = "0x10")]
		public UILabel Label;

		// Token: 0x0400BCFC RID: 48380
		[Token(Token = "0x400BCFC")]
		[FieldOffset(Offset = "0x18")]
		public float RedLabelSeconds;

		// Token: 0x0400BCFD RID: 48381
		[Token(Token = "0x400BCFD")]
		[FieldOffset(Offset = "0x1C")]
		public Color TextNormalColor;

		// Token: 0x0400BCFE RID: 48382
		[Token(Token = "0x400BCFE")]
		[FieldOffset(Offset = "0x2C")]
		public bool Inited;

		// Token: 0x0400BCFF RID: 48383
		[Token(Token = "0x400BCFF")]
		[FieldOffset(Offset = "0x30")]
		private StringBuilder m_Timer;

		// Token: 0x0400BD00 RID: 48384
		[Token(Token = "0x400BD00")]
		[FieldOffset(Offset = "0x38")]
		private int m_LastSeconds;

		// Token: 0x0400BD01 RID: 48385
		[Token(Token = "0x400BD01")]
		[FieldOffset(Offset = "0x3C")]
		private EUITimeUpdateType m_TimeUpdateMethod;

		// Token: 0x0400BD02 RID: 48386
		[Token(Token = "0x400BD02")]
		[FieldOffset(Offset = "0x40")]
		private float m_TimeBase;

		// Token: 0x0400BD03 RID: 48387
		[Token(Token = "0x400BD03")]
		[FieldOffset(Offset = "0x44")]
		private float m_TimeTarget;

		// Token: 0x0400BD04 RID: 48388
		[Token(Token = "0x400BD04")]
		[FieldOffset(Offset = "0x48")]
		private string m_ExtraString;

		// Token: 0x0400BD05 RID: 48389
		[Token(Token = "0x400BD05")]
		[FieldOffset(Offset = "0x50")]
		public EUITimeUpdateStyle showSytle;
	}
}
