using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001490 RID: 5264
	[Token(Token = "0x2001490")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED18C", Offset = "0x10ED18C")]
	public class UIChampionshipTeamApplyItemController : UIEasyListItemController
	{
		// Token: 0x060058F4 RID: 22772 RVA: 0x0001A310 File Offset: 0x00018510
		[Token(Token = "0x60058F4")]
		[Address(RVA = "0x1ECBF20", Offset = "0x1ECBF20", VA = "0x7BBC6CBF20")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F5")]
		[Address(RVA = "0x1ECBF70", Offset = "0x1ECBF70", VA = "0x7BBC6CBF70", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F6")]
		[Address(RVA = "0x1ECC1D4", Offset = "0x1ECC1D4", VA = "0x7BBC6CC1D4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F7")]
		[Address(RVA = "0x1EC6A44", Offset = "0x1EC6A44", VA = "0x7BBC6C6A44")]
		public void SetChampionshipType(uint championshipType)
		{
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F8")]
		[Address(RVA = "0x1ECC2F8", Offset = "0x1ECC2F8", VA = "0x7BBC6CC2F8")]
		private void View()
		{
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F9")]
		[Address(RVA = "0x1ECC398", Offset = "0x1ECC398", VA = "0x7BBC6CC398")]
		private void Reject()
		{
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FA")]
		[Address(RVA = "0x1ECC4F8", Offset = "0x1ECC4F8", VA = "0x7BBC6CC4F8")]
		private void Accept()
		{
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FB")]
		[Address(RVA = "0x1ECC940", Offset = "0x1ECC940", VA = "0x7BBC6CC940")]
		public UIChampionshipTeamApplyItemController()
		{
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FC")]
		[Address(RVA = "0x1ECC948", Offset = "0x1ECC948", VA = "0x7BBC6CC948")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F488", Offset = "0x113F488")]
		private void <Accept>b__13_0()
		{
		}

		// Token: 0x04007CA7 RID: 31911
		[Token(Token = "0x4007CA7")]
		[FieldOffset(Offset = "0x70")]
		private UIChampionshipTeamApplyItemView m_View;

		// Token: 0x04007CA8 RID: 31912
		[Token(Token = "0x4007CA8")]
		[FieldOffset(Offset = "0x78")]
		private UIBaseProfileInfoController m_BaseProfileUI;

		// Token: 0x04007CA9 RID: 31913
		[Token(Token = "0x4007CA9")]
		[FieldOffset(Offset = "0x80")]
		private AccountInfoBasic m_ApplicantData;

		// Token: 0x04007CAA RID: 31914
		[Token(Token = "0x4007CAA")]
		[FieldOffset(Offset = "0x88")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CAB RID: 31915
		[Token(Token = "0x4007CAB")]
		[FieldOffset(Offset = "0x90")]
		public UIChampionshipTeamApplyItemController.ViewType m_ViewType;

		// Token: 0x04007CAC RID: 31916
		[Token(Token = "0x4007CAC")]
		[FieldOffset(Offset = "0x94")]
		private uint m_ChampionshipType;

		// Token: 0x02001491 RID: 5265
		[Token(Token = "0x2001491")]
		public enum ViewType
		{
			// Token: 0x04007CAE RID: 31918
			[Token(Token = "0x4007CAE")]
			Apply,
			// Token: 0x04007CAF RID: 31919
			[Token(Token = "0x4007CAF")]
			Invite
		}
	}
}
