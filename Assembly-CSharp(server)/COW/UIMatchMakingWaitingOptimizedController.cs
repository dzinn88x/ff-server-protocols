using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A68 RID: 6760
	[Token(Token = "0x2001A68")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F81AC", Offset = "0x10F81AC")]
	public class UIMatchMakingWaitingOptimizedController : UIBaseController
	{
		// Token: 0x06008E53 RID: 36435 RVA: 0x00025FB0 File Offset: 0x000241B0
		[Token(Token = "0x6008E53")]
		[Address(RVA = "0x147876C", Offset = "0x147876C", VA = "0x7BBBC7876C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E54 RID: 36436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E54")]
		[Address(RVA = "0x14787BC", Offset = "0x14787BC", VA = "0x7BBBC787BC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E55 RID: 36437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E55")]
		[Address(RVA = "0x1478994", Offset = "0x1478994", VA = "0x7BBBC78994", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E56")]
		[Address(RVA = "0x1478A40", Offset = "0x1478A40", VA = "0x7BBBC78A40")]
		private void Update()
		{
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E57")]
		[Address(RVA = "0x1478B88", Offset = "0x1478B88", VA = "0x7BBBC78B88")]
		protected void OnBtnCancel()
		{
		}

		// Token: 0x06008E58 RID: 36440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E58")]
		[Address(RVA = "0x1478BC0", Offset = "0x1478BC0", VA = "0x7BBBC78BC0")]
		public void SetEstimateTime(uint time)
		{
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E59")]
		[Address(RVA = "0x1478CAC", Offset = "0x1478CAC", VA = "0x7BBBC78CAC")]
		public UIMatchMakingWaitingOptimizedController()
		{
		}

		// Token: 0x040099FC RID: 39420
		[Token(Token = "0x40099FC")]
		[FieldOffset(Offset = "0x58")]
		private UIMatchMakingWaitingOptimizedView m_View;

		// Token: 0x040099FD RID: 39421
		[Token(Token = "0x40099FD")]
		[FieldOffset(Offset = "0x60")]
		private float m_Time;

		// Token: 0x040099FE RID: 39422
		[Token(Token = "0x40099FE")]
		[FieldOffset(Offset = "0x68")]
		public Action OnCancel;
	}
}
