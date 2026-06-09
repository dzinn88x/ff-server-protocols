using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001620 RID: 5664
	[Token(Token = "0x2001620")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFB8C", Offset = "0x10EFB8C")]
	internal class UIHudPVEBossHPController : UIBaseController
	{
		// Token: 0x060065CA RID: 26058 RVA: 0x0001D148 File Offset: 0x0001B348
		[Token(Token = "0x60065CA")]
		[Address(RVA = "0x17BF80C", Offset = "0x17BF80C", VA = "0x7BBBFBF80C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CB")]
		[Address(RVA = "0x17BF85C", Offset = "0x17BF85C", VA = "0x7BBBFBF85C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CC")]
		[Address(RVA = "0x17BFA68", Offset = "0x17BFA68", VA = "0x7BBBFBFA68", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CD")]
		[Address(RVA = "0x17BFC30", Offset = "0x17BFC30", VA = "0x7BBBFBFC30")]
		private void OnBossSpawn(object[] data)
		{
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CE")]
		[Address(RVA = "0x17BFCA8", Offset = "0x17BFCA8", VA = "0x7BBBFBFCA8")]
		private void OnBossDead(object[] data)
		{
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CF")]
		[Address(RVA = "0x17BFD20", Offset = "0x17BFD20", VA = "0x7BBBFBFD20")]
		private void OnBossHPChanged(object[] data)
		{
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D0")]
		[Address(RVA = "0x17BFEE4", Offset = "0x17BFEE4", VA = "0x7BBBFBFEE4")]
		private void CheckHPLayerChange(int preLayerIndex, int curLayerIndex)
		{
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D1")]
		[Address(RVA = "0x17C01EC", Offset = "0x17C01EC", VA = "0x7BBBFC01EC")]
		private void OnBossColorChanged(object[] data)
		{
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D2")]
		[Address(RVA = "0x17C01F0", Offset = "0x17C01F0", VA = "0x7BBBFC01F0")]
		public UIHudPVEBossHPController()
		{
		}

		// Token: 0x040083E1 RID: 33761
		[Token(Token = "0x40083E1")]
		private const int CONST_HPMaxLayerNum = 5;

		// Token: 0x040083E2 RID: 33762
		[Token(Token = "0x40083E2")]
		[FieldOffset(Offset = "0x58")]
		private int m_CurHPLayerIndex;

		// Token: 0x040083E3 RID: 33763
		[Token(Token = "0x40083E3")]
		[FieldOffset(Offset = "0x60")]
		private UIHudPVEBossHPView m_View;
	}
}
