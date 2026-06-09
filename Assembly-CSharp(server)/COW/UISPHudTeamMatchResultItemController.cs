using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B9C RID: 7068
	[Token(Token = "0x2001B9C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA804", Offset = "0x10FA804")]
	public class UISPHudTeamMatchResultItemController : UIEasyListItemController
	{
		// Token: 0x06009889 RID: 39049 RVA: 0x000282A8 File Offset: 0x000264A8
		[Token(Token = "0x6009889")]
		[Address(RVA = "0x1EF860C", Offset = "0x1EF860C", VA = "0x7BBC6F860C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600988A RID: 39050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600988A")]
		[Address(RVA = "0x1EF865C", Offset = "0x1EF865C", VA = "0x7BBC6F865C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600988B")]
		[Address(RVA = "0x1EF86C0", Offset = "0x1EF86C0", VA = "0x7BBC6F86C0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600988C")]
		[Address(RVA = "0x1EF8E50", Offset = "0x1EF8E50", VA = "0x7BBC6F8E50")]
		public UISPHudTeamMatchResultItemController()
		{
		}

		// Token: 0x0400A03A RID: 41018
		[Token(Token = "0x400A03A")]
		[FieldOffset(Offset = "0x70")]
		private UISPHudTeamMatchResultItemView m_View;
	}
}
