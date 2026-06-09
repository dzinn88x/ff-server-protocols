using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B6A RID: 7018
	[Token(Token = "0x2001B6A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9FB4", Offset = "0x10F9FB4")]
	public class UIRoomModeSelectPopupWindowController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06009704 RID: 38660 RVA: 0x00027DF8 File Offset: 0x00025FF8
		[Token(Token = "0x6009704")]
		[Address(RVA = "0x1A1B95C", Offset = "0x1A1B95C", VA = "0x7BBC21B95C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009705 RID: 38661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009705")]
		[Address(RVA = "0x1A15BAC", Offset = "0x1A15BAC", VA = "0x7BBC215BAC")]
		public static void ClearSavedData()
		{
		}

		// Token: 0x06009706 RID: 38662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009706")]
		[Address(RVA = "0x1A15B80", Offset = "0x1A15B80", VA = "0x7BBC215B80")]
		public void SetApplyCallBackFn(Action callback)
		{
		}

		// Token: 0x06009707 RID: 38663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009707")]
		[Address(RVA = "0x1A1B9AC", Offset = "0x1A1B9AC", VA = "0x7BBC21B9AC", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009708")]
		[Address(RVA = "0x1A1B9DC", Offset = "0x1A1B9DC", VA = "0x7BBC21B9DC", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06009709 RID: 38665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009709")]
		[Address(RVA = "0x1A15A8C", Offset = "0x1A15A8C", VA = "0x7BBC215A8C")]
		public void SetItemsData(List<FRoomModeSelectData> list, string countDownTxt = "")
		{
		}

		// Token: 0x0600970A RID: 38666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600970A")]
		[Address(RVA = "0x1A160F0", Offset = "0x1A160F0", VA = "0x7BBC2160F0")]
		public void OnCountDownStarted()
		{
		}

		// Token: 0x0600970B RID: 38667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600970B")]
		[Address(RVA = "0x1A16204", Offset = "0x1A16204", VA = "0x7BBC216204")]
		public void OnCountDownUpdate(string countDownTxt)
		{
		}

		// Token: 0x0600970C RID: 38668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600970C")]
		[Address(RVA = "0x1A1624C", Offset = "0x1A1624C", VA = "0x7BBC21624C")]
		public void OnCountDownFinished()
		{
		}

		// Token: 0x0600970D RID: 38669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600970D")]
		[Address(RVA = "0x1A1BA70", Offset = "0x1A1BA70", VA = "0x7BBC21BA70", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600970E RID: 38670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600970E")]
		[Address(RVA = "0x1A1C438", Offset = "0x1A1C438", VA = "0x7BBC21C438", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600970F RID: 38671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600970F")]
		[Address(RVA = "0x1A1C6B8", Offset = "0x1A1C6B8", VA = "0x7BBC21C6B8")]
		private void UpdateGroupMode()
		{
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009710")]
		[Address(RVA = "0x1A1C7F0", Offset = "0x1A1C7F0", VA = "0x7BBC21C7F0")]
		public void OnClickPassword()
		{
		}

		// Token: 0x06009711 RID: 38673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009711")]
		[Address(RVA = "0x1A1C2A8", Offset = "0x1A1C2A8", VA = "0x7BBC21C2A8")]
		private void UpdatePasswordView()
		{
		}

		// Token: 0x06009712 RID: 38674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009712")]
		[Address(RVA = "0x1A1C98C", Offset = "0x1A1C98C", VA = "0x7BBC21C98C")]
		public void OnClickSimulator()
		{
		}

		// Token: 0x06009713 RID: 38675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009713")]
		[Address(RVA = "0x1A1C370", Offset = "0x1A1C370", VA = "0x7BBC21C370")]
		private void UpdateSimulatorView()
		{
		}

		// Token: 0x06009714 RID: 38676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009714")]
		[Address(RVA = "0x1A1CB28", Offset = "0x1A1CB28", VA = "0x7BBC21CB28")]
		private void OnClickApplyBtn()
		{
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009715")]
		[Address(RVA = "0x1A1CB60", Offset = "0x1A1CB60", VA = "0x7BBC21CB60")]
		public UIRoomModeSelectPopupWindowController()
		{
		}

		// Token: 0x06009717 RID: 38679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009717")]
		[Address(RVA = "0x1A1CE28", Offset = "0x1A1CE28", VA = "0x7BBC21CE28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D70", Offset = "0x1144D70")]
		private void <OnClickPassword>b__26_0(List<string> ids)
		{
		}

		// Token: 0x06009718 RID: 38680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009718")]
		[Address(RVA = "0x1A1CE30", Offset = "0x1A1CE30", VA = "0x7BBC21CE30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D80", Offset = "0x1144D80")]
		private void <OnClickSimulator>b__28_0(List<string> ids)
		{
		}

		// Token: 0x04009F4D RID: 40781
		[Token(Token = "0x4009F4D")]
		[FieldOffset(Offset = "0x98")]
		private UIRoomModeSelectPopupWindowView m_View;

		// Token: 0x04009F4E RID: 40782
		[Token(Token = "0x4009F4E")]
		[FieldOffset(Offset = "0xA0")]
		private Action OnApplyCallBackFn;

		// Token: 0x04009F4F RID: 40783
		[Token(Token = "0x4009F4F")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIRoomModeSelectPopupItemController> m_GroupModes;

		// Token: 0x04009F50 RID: 40784
		[Token(Token = "0x4009F50")]
		[FieldOffset(Offset = "0xB0")]
		private UIWidget m_PasswordWidget;

		// Token: 0x04009F51 RID: 40785
		[Token(Token = "0x4009F51")]
		[FieldOffset(Offset = "0xB8")]
		private UIWidget m_SimulatorWidget;

		// Token: 0x04009F52 RID: 40786
		[Token(Token = "0x4009F52")]
		[FieldOffset(Offset = "0xC0")]
		private List<string> m_PasswordIDs;

		// Token: 0x04009F53 RID: 40787
		[Token(Token = "0x4009F53")]
		[FieldOffset(Offset = "0xC8")]
		private List<string> m_SimulatorIDs;

		// Token: 0x04009F54 RID: 40788
		[Token(Token = "0x4009F54")]
		[FieldOffset(Offset = "0xD0")]
		private List<string> m_PasswordAllIDs;

		// Token: 0x04009F55 RID: 40789
		[Token(Token = "0x4009F55")]
		[FieldOffset(Offset = "0xD8")]
		private List<string> m_SimulatorAllIDs;

		// Token: 0x04009F56 RID: 40790
		[Token(Token = "0x4009F56")]
		[FieldOffset(Offset = "0xE0")]
		private List<MultiPopMenuListData> m_PopMenuListPasswords;

		// Token: 0x04009F57 RID: 40791
		[Token(Token = "0x4009F57")]
		[FieldOffset(Offset = "0xE8")]
		private List<MultiPopMenuListData> m_PopMenuListSimulators;

		// Token: 0x04009F58 RID: 40792
		[Token(Token = "0x4009F58")]
		[FieldOffset(Offset = "0x0")]
		private static bool[] m_LastSelectGameModes;

		// Token: 0x04009F59 RID: 40793
		[Token(Token = "0x4009F59")]
		[FieldOffset(Offset = "0x8")]
		private static int m_LastSelectPasswordIndex;

		// Token: 0x04009F5A RID: 40794
		[Token(Token = "0x4009F5A")]
		[FieldOffset(Offset = "0xC")]
		private static int m_LastSelectSimulatorIndex;
	}
}
