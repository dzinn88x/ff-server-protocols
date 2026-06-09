using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001411 RID: 5137
	[Token(Token = "0x2001411")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC550", Offset = "0x10EC550")]
	internal class UIAnniversaryLobbyEnterItemControler : UIEasyListItemController
	{
		// Token: 0x060054AD RID: 21677 RVA: 0x000194A0 File Offset: 0x000176A0
		[Token(Token = "0x60054AD")]
		[Address(RVA = "0x1B0FBA4", Offset = "0x1B0FBA4", VA = "0x7BBC30FBA4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054AE")]
		[Address(RVA = "0x1B0FBF4", Offset = "0x1B0FBF4", VA = "0x7BBC30FBF4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054AF")]
		[Address(RVA = "0x1B0FD30", Offset = "0x1B0FD30", VA = "0x7BBC30FD30", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B0")]
		[Address(RVA = "0x1B0FD38", Offset = "0x1B0FD38", VA = "0x7BBC30FD38", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B1")]
		[Address(RVA = "0x1B0FE5C", Offset = "0x1B0FE5C", VA = "0x7BBC30FE5C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B2")]
		[Address(RVA = "0x1B0FE64", Offset = "0x1B0FE64", VA = "0x7BBC30FE64", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B3")]
		[Address(RVA = "0x1B109BC", Offset = "0x1B109BC", VA = "0x7BBC3109BC")]
		private void OnGotoBtnClick()
		{
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B4")]
		[Address(RVA = "0x1B10DFC", Offset = "0x1B10DFC", VA = "0x7BBC310DFC")]
		private void OnNotifyCheckboxChange()
		{
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B5")]
		[Address(RVA = "0x1B10EE8", Offset = "0x1B10EE8", VA = "0x7BBC310EE8")]
		public UIAnniversaryLobbyEnterItemControler()
		{
		}

		// Token: 0x040079F2 RID: 31218
		[Token(Token = "0x40079F2")]
		[FieldOffset(Offset = "0x70")]
		private UIAnniversaryEnterItemView m_View;

		// Token: 0x040079F3 RID: 31219
		[Token(Token = "0x40079F3")]
		[FieldOffset(Offset = "0x78")]
		private ulong m_StartTimeStamp;

		// Token: 0x040079F4 RID: 31220
		[Token(Token = "0x40079F4")]
		[FieldOffset(Offset = "0x80")]
		private ulong m_EndTimeStamp;

		// Token: 0x040079F5 RID: 31221
		[Token(Token = "0x40079F5")]
		[FieldOffset(Offset = "0x88")]
		private BigEventEntryDesc m_ViewData;
	}
}
