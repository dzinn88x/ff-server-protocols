using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200149D RID: 5277
	[Token(Token = "0x200149D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED36C", Offset = "0x10ED36C")]
	public class UIChampionshipTeamOverviewController : UIBaseController
	{
		// Token: 0x06005966 RID: 22886 RVA: 0x0001A520 File Offset: 0x00018720
		[Token(Token = "0x6005966")]
		[Address(RVA = "0x1ED550C", Offset = "0x1ED550C", VA = "0x7BBC6D550C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005967")]
		[Address(RVA = "0x1ED555C", Offset = "0x1ED555C", VA = "0x7BBC6D555C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005968")]
		[Address(RVA = "0x1ED5850", Offset = "0x1ED5850", VA = "0x7BBC6D5850")]
		public void SetData(TeamInfo teamInfo, uint championshipType, bool showEditButton = false)
		{
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005969")]
		[Address(RVA = "0x1ED5F1C", Offset = "0x1ED5F1C", VA = "0x7BBC6D5F1C")]
		public void SetNationFlag(UISprite flagSprite, TeamInfo teamInfo)
		{
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600596A")]
		[Address(RVA = "0x1ED6138", Offset = "0x1ED6138", VA = "0x7BBC6D6138")]
		protected void EditInfo()
		{
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600596B")]
		[Address(RVA = "0x1ED61D8", Offset = "0x1ED61D8", VA = "0x7BBC6D61D8")]
		public UIChampionshipTeamOverviewController()
		{
		}

		// Token: 0x04007CED RID: 31981
		[Token(Token = "0x4007CED")]
		[FieldOffset(Offset = "0x58")]
		private UIChampionshipTeamOverviewView m_View;

		// Token: 0x04007CEE RID: 31982
		[Token(Token = "0x4007CEE")]
		[FieldOffset(Offset = "0x60")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CEF RID: 31983
		[Token(Token = "0x4007CEF")]
		[FieldOffset(Offset = "0x68")]
		private EChampionship.TeamScaleType m_TeamScale;
	}
}
