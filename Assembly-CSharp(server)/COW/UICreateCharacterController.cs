using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200176E RID: 5998
	[Token(Token = "0x200176E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F209C", Offset = "0x10F209C")]
	public class UICreateCharacterController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600712A RID: 28970 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		[Token(Token = "0x600712A")]
		[Address(RVA = "0x1819520", Offset = "0x1819520", VA = "0x7BBC019520")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600712B")]
		[Address(RVA = "0x1819570", Offset = "0x1819570", VA = "0x7BBC019570", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600712C")]
		[Address(RVA = "0x1819BD8", Offset = "0x1819BD8", VA = "0x7BBC019BD8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600712D")]
		[Address(RVA = "0x1819D10", Offset = "0x1819D10", VA = "0x7BBC019D10")]
		private void OnCloseBtnClick()
		{
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600712E")]
		[Address(RVA = "0x1819D18", Offset = "0x1819D18", VA = "0x7BBC019D18")]
		public void SetUIContent(string userName, uint avatarID)
		{
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600712F")]
		[Address(RVA = "0x1819D80", Offset = "0x1819D80", VA = "0x7BBC019D80")]
		private void OnInputChange()
		{
		}

		// Token: 0x06007130 RID: 28976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007130")]
		[Address(RVA = "0x1819ECC", Offset = "0x1819ECC", VA = "0x7BBC019ECC")]
		private void OnRegisterClick()
		{
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007131")]
		[Address(RVA = "0x181A488", Offset = "0x181A488", VA = "0x7BBC01A488", Slot = "28")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007132 RID: 28978 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		[Token(Token = "0x6007132")]
		[Address(RVA = "0x181A504", Offset = "0x181A504", VA = "0x7BBC01A504", Slot = "29")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007133")]
		[Address(RVA = "0x181A548", Offset = "0x181A548", VA = "0x7BBC01A548")]
		public void OnDuplicateUsername(params object[] param)
		{
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007134")]
		[Address(RVA = "0x1819948", Offset = "0x1819948", VA = "0x7BBC019948")]
		public void CreateRandomName()
		{
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007135")]
		[Address(RVA = "0x181A604", Offset = "0x181A604", VA = "0x7BBC01A604")]
		public UICreateCharacterController()
		{
		}

		// Token: 0x04008ACA RID: 35530
		[Token(Token = "0x4008ACA")]
		[FieldOffset(Offset = "0x58")]
		private UICreateCharacterView m_View;

		// Token: 0x04008ACB RID: 35531
		[Token(Token = "0x4008ACB")]
		[FieldOffset(Offset = "0x60")]
		private uint m_AvatarId;

		// Token: 0x04008ACC RID: 35532
		[Token(Token = "0x4008ACC")]
		[FieldOffset(Offset = "0x68")]
		private List<NickNamePreListData> m_nickNameList;
	}
}
