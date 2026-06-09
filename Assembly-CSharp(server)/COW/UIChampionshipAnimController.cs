using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001463 RID: 5219
	[Token(Token = "0x2001463")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECCB0", Offset = "0x10ECCB0")]
	public class UIChampionshipAnimController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060057C3 RID: 22467 RVA: 0x00019F50 File Offset: 0x00018150
		[Token(Token = "0x60057C3")]
		[Address(RVA = "0x1C24D9C", Offset = "0x1C24D9C", VA = "0x7BBC424D9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C4")]
		[Address(RVA = "0x1C24DEC", Offset = "0x1C24DEC", VA = "0x7BBC424DEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C5")]
		[Address(RVA = "0x1C24F9C", Offset = "0x1C24F9C", VA = "0x7BBC424F9C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C6")]
		[Address(RVA = "0x1C24FDC", Offset = "0x1C24FDC", VA = "0x7BBC424FDC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C7")]
		[Address(RVA = "0x1C25088", Offset = "0x1C25088", VA = "0x7BBC425088")]
		public void RefreshView(List<UIChampionshipAnimController.CSAnimInfo> m_AnimTypeList)
		{
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C8")]
		[Address(RVA = "0x1C250D4", Offset = "0x1C250D4", VA = "0x7BBC4250D4")]
		private void AnimCreateFactory(List<UIChampionshipAnimController.CSAnimInfo> m_AnimInfoList)
		{
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C9")]
		[Address(RVA = "0x1C2537C", Offset = "0x1C2537C", VA = "0x7BBC42537C")]
		private void AnimListInit()
		{
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x00019F68 File Offset: 0x00018168
		[Token(Token = "0x60057CA")]
		[Address(RVA = "0x1C254FC", Offset = "0x1C254FC", VA = "0x7BBC4254FC")]
		private bool PlayAnim()
		{
			return default(bool);
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CB")]
		[Address(RVA = "0x1C257C8", Offset = "0x1C257C8", VA = "0x7BBC4257C8")]
		public void SetSeasonInfo(uint championshipID, uint championshipType)
		{
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CC")]
		[Address(RVA = "0x1C25A9C", Offset = "0x1C25A9C", VA = "0x7BBC425A9C")]
		public void SetAwardInfo(uint championshipID, uint championshipType)
		{
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CD")]
		[Address(RVA = "0x1C26038", Offset = "0x1C26038", VA = "0x7BBC426038")]
		private void SetRankNum(AccountChampionshipInfo accountInfo, uint localSize)
		{
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CE")]
		[Address(RVA = "0x1C26298", Offset = "0x1C26298", VA = "0x7BBC426298", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CF")]
		[Address(RVA = "0x1C262F8", Offset = "0x1C262F8", VA = "0x7BBC4262F8")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D0")]
		[Address(RVA = "0x1C26330", Offset = "0x1C26330", VA = "0x7BBC426330")]
		private void OnGotoMailBtnClick()
		{
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D1")]
		[Address(RVA = "0x1C2640C", Offset = "0x1C2640C", VA = "0x7BBC42640C", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x00019F80 File Offset: 0x00018180
		[Token(Token = "0x60057D2")]
		[Address(RVA = "0x1C26690", Offset = "0x1C26690", VA = "0x7BBC426690", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D3")]
		[Address(RVA = "0x1C26728", Offset = "0x1C26728", VA = "0x7BBC426728")]
		public UIChampionshipAnimController()
		{
		}

		// Token: 0x04007BE4 RID: 31716
		[Token(Token = "0x4007BE4")]
		[FieldOffset(Offset = "0x98")]
		private UIChampionshipAnimView m_View;

		// Token: 0x04007BE5 RID: 31717
		[Token(Token = "0x4007BE5")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007BE6 RID: 31718
		[Token(Token = "0x4007BE6")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIChampionshipAnimController.ChampionshipAnimBase> m_AnimList;

		// Token: 0x04007BE7 RID: 31719
		[Token(Token = "0x4007BE7")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_Flag;

		// Token: 0x04007BE8 RID: 31720
		[Token(Token = "0x4007BE8")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<uint, string> m_CupIconDict;

		// Token: 0x02001464 RID: 5220
		[Token(Token = "0x2001464")]
		private abstract class ChampionshipAnimBase : IComparable<UIChampionshipAnimController.ChampionshipAnimBase>
		{
			// Token: 0x060057D4 RID: 22484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057D4")]
			[Address(RVA = "0x1C26CC8", Offset = "0x1C26CC8", VA = "0x7BBC426CC8", Slot = "5")]
			public virtual void InitAnimInfo()
			{
			}

			// Token: 0x060057D5 RID: 22485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057D5")]
			[Address(RVA = "0x1C26CBC", Offset = "0x1C26CBC", VA = "0x7BBC426CBC", Slot = "6")]
			public virtual void SetAnimCSInfo()
			{
			}

			// Token: 0x060057D6 RID: 22486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057D6")]
			[Address(RVA = "0x1C2687C", Offset = "0x1C2687C", VA = "0x7BBC42687C")]
			public ChampionshipAnimBase(UIChampionshipAnimController ctrl, uint championshipType)
			{
			}

			// Token: 0x060057D7 RID: 22487 RVA: 0x00019F98 File Offset: 0x00018198
			[Token(Token = "0x60057D7")]
			[Address(RVA = "0x1C26CCC", Offset = "0x1C26CCC", VA = "0x7BBC426CCC", Slot = "4")]
			public int CompareTo(UIChampionshipAnimController.ChampionshipAnimBase other)
			{
				return 0;
			}

			// Token: 0x04007BE9 RID: 31721
			[Token(Token = "0x4007BE9")]
			[FieldOffset(Offset = "0x10")]
			public string m_AnimTrigger;

			// Token: 0x04007BEA RID: 31722
			[Token(Token = "0x4007BEA")]
			[FieldOffset(Offset = "0x18")]
			public uint m_NotifyFlag;

			// Token: 0x04007BEB RID: 31723
			[Token(Token = "0x4007BEB")]
			[FieldOffset(Offset = "0x1C")]
			protected uint m_SortIndex;

			// Token: 0x04007BEC RID: 31724
			[Token(Token = "0x4007BEC")]
			[FieldOffset(Offset = "0x20")]
			protected UIChampionshipAnimController m_Ctrl;

			// Token: 0x04007BED RID: 31725
			[Token(Token = "0x4007BED")]
			[FieldOffset(Offset = "0x28")]
			protected uint m_CurrentChampionshipID;

			// Token: 0x04007BEE RID: 31726
			[Token(Token = "0x4007BEE")]
			[FieldOffset(Offset = "0x2C")]
			protected uint m_ChampionshipType;
		}

		// Token: 0x02001465 RID: 5221
		[Token(Token = "0x2001465")]
		private class AwardAnim : UIChampionshipAnimController.ChampionshipAnimBase
		{
			// Token: 0x060057D8 RID: 22488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057D8")]
			[Address(RVA = "0x1C256E0", Offset = "0x1C256E0", VA = "0x7BBC4256E0")]
			public AwardAnim(UIChampionshipAnimController ctrl, uint championshipType)
			{
			}

			// Token: 0x060057D9 RID: 22489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057D9")]
			[Address(RVA = "0x1C26950", Offset = "0x1C26950", VA = "0x7BBC426950", Slot = "5")]
			public override void InitAnimInfo()
			{
			}

			// Token: 0x060057DA RID: 22490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057DA")]
			[Address(RVA = "0x1C26954", Offset = "0x1C26954", VA = "0x7BBC426954")]
			private void RequestData()
			{
			}

			// Token: 0x060057DB RID: 22491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057DB")]
			[Address(RVA = "0x1C26B1C", Offset = "0x1C26B1C", VA = "0x7BBC426B1C", Slot = "6")]
			public override void SetAnimCSInfo()
			{
			}

			// Token: 0x04007BEF RID: 31727
			[Token(Token = "0x4007BEF")]
			[FieldOffset(Offset = "0x30")]
			private ChampionshipInfo championshipInfo;
		}

		// Token: 0x02001466 RID: 5222
		[Token(Token = "0x2001466")]
		private class AwardAnimNoPos : UIChampionshipAnimController.AwardAnim
		{
			// Token: 0x060057DC RID: 22492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057DC")]
			[Address(RVA = "0x1C25758", Offset = "0x1C25758", VA = "0x7BBC425758")]
			public AwardAnimNoPos(UIChampionshipAnimController ctrl, uint championshipType)
			{
			}
		}

		// Token: 0x02001467 RID: 5223
		[Token(Token = "0x2001467")]
		private class SeasonAnim : UIChampionshipAnimController.ChampionshipAnimBase
		{
			// Token: 0x060057DD RID: 22493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057DD")]
			[Address(RVA = "0x1C25668", Offset = "0x1C25668", VA = "0x7BBC425668")]
			public SeasonAnim(UIChampionshipAnimController ctrl, uint championshipType)
			{
			}

			// Token: 0x060057DE RID: 22494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057DE")]
			[Address(RVA = "0x1C26D04", Offset = "0x1C26D04", VA = "0x7BBC426D04", Slot = "6")]
			public override void SetAnimCSInfo()
			{
			}
		}

		// Token: 0x02001468 RID: 5224
		[Token(Token = "0x2001468")]
		public enum CSAnimType
		{
			// Token: 0x04007BF1 RID: 31729
			[Token(Token = "0x4007BF1")]
			Season,
			// Token: 0x04007BF2 RID: 31730
			[Token(Token = "0x4007BF2")]
			Award,
			// Token: 0x04007BF3 RID: 31731
			[Token(Token = "0x4007BF3")]
			AwardNoPos
		}

		// Token: 0x02001469 RID: 5225
		[Token(Token = "0x2001469")]
		public class CSAnimInfo
		{
			// Token: 0x060057DF RID: 22495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60057DF")]
			[Address(RVA = "0x1C26CC0", Offset = "0x1C26CC0", VA = "0x7BBC426CC0")]
			public CSAnimInfo()
			{
			}

			// Token: 0x04007BF4 RID: 31732
			[Token(Token = "0x4007BF4")]
			[FieldOffset(Offset = "0x10")]
			public UIChampionshipAnimController.CSAnimType m_AnimType;

			// Token: 0x04007BF5 RID: 31733
			[Token(Token = "0x4007BF5")]
			[FieldOffset(Offset = "0x14")]
			public uint m_ChampionshipType;
		}
	}
}
