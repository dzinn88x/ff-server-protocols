using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200146A RID: 5226
	[Token(Token = "0x200146A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECCE8", Offset = "0x10ECCE8")]
	public class UIChampionshipChannelItemController : UIBaseController
	{
		// Token: 0x060057E0 RID: 22496 RVA: 0x00019FB0 File Offset: 0x000181B0
		[Token(Token = "0x60057E0")]
		[Address(RVA = "0x1C27290", Offset = "0x1C27290", VA = "0x7BBC427290")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E1")]
		[Address(RVA = "0x1C272E0", Offset = "0x1C272E0", VA = "0x7BBC4272E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E2")]
		[Address(RVA = "0x1C273C4", Offset = "0x1C273C4", VA = "0x7BBC4273C4")]
		public void SetData(ChampionshipChannelData data)
		{
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E3")]
		[Address(RVA = "0x1C273CC", Offset = "0x1C273CC", VA = "0x7BBC4273CC")]
		private void RefreshView()
		{
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E4")]
		[Address(RVA = "0x1C2743C", Offset = "0x1C2743C", VA = "0x7BBC42743C")]
		private void SelectChannel()
		{
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E5")]
		[Address(RVA = "0x1C27574", Offset = "0x1C27574", VA = "0x7BBC427574")]
		public UIChampionshipChannelItemController()
		{
		}

		// Token: 0x04007BF6 RID: 31734
		[Token(Token = "0x4007BF6")]
		[FieldOffset(Offset = "0x58")]
		private UIChampionshipChannelItemView m_View;

		// Token: 0x04007BF7 RID: 31735
		[Token(Token = "0x4007BF7")]
		[FieldOffset(Offset = "0x60")]
		private ChampionshipChannelData m_ChannelData;
	}
}
