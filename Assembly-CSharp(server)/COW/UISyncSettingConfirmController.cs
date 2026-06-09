using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BAA RID: 7082
	[Token(Token = "0x2001BAA")]
	public class UISyncSettingConfirmController : UIPopupWindowController
	{
		// Token: 0x060098DB RID: 39131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098DB")]
		[Address(RVA = "0x1F4F194", Offset = "0x1F4F194", VA = "0x7BBC74F194", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098DC")]
		[Address(RVA = "0x1F4F780", Offset = "0x1F4F780", VA = "0x7BBC74F780")]
		private void RequestUploadSetting()
		{
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098DD")]
		[Address(RVA = "0x1F4F7C0", Offset = "0x1F4F7C0", VA = "0x7BBC74F7C0")]
		private void RequestDownloadSetting()
		{
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x000283F8 File Offset: 0x000265F8
		[Token(Token = "0x60098DE")]
		[Address(RVA = "0x1F4F800", Offset = "0x1F4F800", VA = "0x7BBC74F800")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098DF")]
		[Address(RVA = "0x1F4F570", Offset = "0x1F4F570", VA = "0x7BBC74F570")]
		public void ResetContainer()
		{
		}

		// Token: 0x060098E0 RID: 39136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E0")]
		[Address(RVA = "0x1F4F850", Offset = "0x1F4F850", VA = "0x7BBC74F850")]
		public void SetStatus(UIModelSetting.SyncStatus status)
		{
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E1")]
		[Address(RVA = "0x1F4F98C", Offset = "0x1F4F98C", VA = "0x7BBC74F98C")]
		public UISyncSettingConfirmController()
		{
		}

		// Token: 0x0400A074 RID: 41076
		[Token(Token = "0x400A074")]
		[FieldOffset(Offset = "0x98")]
		private UISyncSettingConfirmView m_View;

		// Token: 0x0400A075 RID: 41077
		[Token(Token = "0x400A075")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelSetting m_Model;
	}
}
