using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200161E RID: 5662
	[Token(Token = "0x200161E")]
	public class UIHUDPlayerGodBarController : UIBaseController
	{
		// Token: 0x060065BD RID: 26045 RVA: 0x0001D118 File Offset: 0x0001B318
		[Token(Token = "0x60065BD")]
		[Address(RVA = "0x16BD2DC", Offset = "0x16BD2DC", VA = "0x7BBBEBD2DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BE")]
		[Address(RVA = "0x16BD32C", Offset = "0x16BD32C", VA = "0x7BBBEBD32C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BF")]
		[Address(RVA = "0x16BD464", Offset = "0x16BD464", VA = "0x7BBBEBD464", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C0")]
		[Address(RVA = "0x16BD584", Offset = "0x16BD584", VA = "0x7BBBEBD584")]
		private void OnShowGod(params object[] data)
		{
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C1")]
		[Address(RVA = "0x16BD670", Offset = "0x16BD670", VA = "0x7BBBEBD670")]
		public void OnGodBegin(float godEndTime)
		{
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C2")]
		[Address(RVA = "0x16BD760", Offset = "0x16BD760", VA = "0x7BBBEBD760")]
		private void Update()
		{
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C3")]
		[Address(RVA = "0x16BD8B4", Offset = "0x16BD8B4", VA = "0x7BBBEBD8B4")]
		private void OnSightingStateChanged(params object[] data)
		{
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C4")]
		[Address(RVA = "0x16BD9A4", Offset = "0x16BD9A4", VA = "0x7BBBEBD9A4")]
		public UIHUDPlayerGodBarController()
		{
		}

		// Token: 0x040083DB RID: 33755
		[Token(Token = "0x40083DB")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDPlayerGodBarView m_View;

		// Token: 0x040083DC RID: 33756
		[Token(Token = "0x40083DC")]
		[FieldOffset(Offset = "0x60")]
		private bool m_IsGoding;

		// Token: 0x040083DD RID: 33757
		[Token(Token = "0x40083DD")]
		[FieldOffset(Offset = "0x64")]
		private float m_GodBeginTime;

		// Token: 0x040083DE RID: 33758
		[Token(Token = "0x40083DE")]
		[FieldOffset(Offset = "0x68")]
		private float m_GodEndTime;
	}
}
