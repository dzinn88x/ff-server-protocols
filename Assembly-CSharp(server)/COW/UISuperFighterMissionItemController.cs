using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013D2 RID: 5074
	[Token(Token = "0x20013D2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBF90", Offset = "0x10EBF90")]
	public class UISuperFighterMissionItemController : UIBaseController
	{
		// Token: 0x06005320 RID: 21280 RVA: 0x00018D98 File Offset: 0x00016F98
		[Token(Token = "0x6005320")]
		[Address(RVA = "0x1F4CF24", Offset = "0x1F4CF24", VA = "0x7BBC74CF24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005321")]
		[Address(RVA = "0x1F4CF74", Offset = "0x1F4CF74", VA = "0x7BBC74CF74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005322")]
		[Address(RVA = "0x1F4D0B0", Offset = "0x1F4D0B0", VA = "0x7BBC74D0B0")]
		public void SetView(ClientActivityDesc desc)
		{
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005323")]
		[Address(RVA = "0x1F4D640", Offset = "0x1F4D640", VA = "0x7BBC74D640")]
		private void OnBtnClaimClick()
		{
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005324")]
		[Address(RVA = "0x1F4D680", Offset = "0x1F4D680", VA = "0x7BBC74D680", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005325")]
		[Address(RVA = "0x1F4D688", Offset = "0x1F4D688", VA = "0x7BBC74D688")]
		public UISuperFighterMissionItemController()
		{
		}

		// Token: 0x040078E2 RID: 30946
		[Token(Token = "0x40078E2")]
		[FieldOffset(Offset = "0x58")]
		private UISuperFighterMissionItemView m_View;

		// Token: 0x040078E3 RID: 30947
		[Token(Token = "0x40078E3")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040078E4 RID: 30948
		[Token(Token = "0x40078E4")]
		[FieldOffset(Offset = "0x68")]
		private UIStandardItemMiniController m_AwardCtrl;

		// Token: 0x040078E5 RID: 30949
		[Token(Token = "0x40078E5")]
		[FieldOffset(Offset = "0x70")]
		private uint m_ActivityId;
	}
}
