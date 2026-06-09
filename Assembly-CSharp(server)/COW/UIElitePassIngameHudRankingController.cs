using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001796 RID: 6038
	[Token(Token = "0x2001796")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2584", Offset = "0x10F2584")]
	public class UIElitePassIngameHudRankingController : UIBaseController
	{
		// Token: 0x060072ED RID: 29421 RVA: 0x0001FF08 File Offset: 0x0001E108
		[Token(Token = "0x60072ED")]
		[Address(RVA = "0x1AE7E40", Offset = "0x1AE7E40", VA = "0x7BBC2E7E40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EE")]
		[Address(RVA = "0x1AE7E90", Offset = "0x1AE7E90", VA = "0x7BBC2E7E90", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EF")]
		[Address(RVA = "0x1AE805C", Offset = "0x1AE805C", VA = "0x7BBC2E805C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F0")]
		[Address(RVA = "0x1AE8128", Offset = "0x1AE8128", VA = "0x7BBC2E8128")]
		public void ShowElite(bool flag)
		{
		}

		// Token: 0x060072F1 RID: 29425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F1")]
		[Address(RVA = "0x1AE8180", Offset = "0x1AE8180", VA = "0x7BBC2E8180")]
		private void ShowRanking(params object[] param)
		{
		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F2")]
		[Address(RVA = "0x1AE86FC", Offset = "0x1AE86FC", VA = "0x7BBC2E86FC")]
		public UIElitePassIngameHudRankingController()
		{
		}

		// Token: 0x04008BBC RID: 35772
		[Token(Token = "0x4008BBC")]
		[FieldOffset(Offset = "0x58")]
		private UIElitePassIngameHudRankingView m_View;
	}
}
