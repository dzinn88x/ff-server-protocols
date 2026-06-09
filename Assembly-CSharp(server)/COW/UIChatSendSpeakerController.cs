using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001702 RID: 5890
	[Token(Token = "0x2001702")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1444", Offset = "0x10F1444")]
	public class UIChatSendSpeakerController : UIPopupWindowController
	{
		// Token: 0x06006D8F RID: 28047 RVA: 0x0001EE10 File Offset: 0x0001D010
		[Token(Token = "0x6006D8F")]
		[Address(RVA = "0x1BE9DC8", Offset = "0x1BE9DC8", VA = "0x7BBC3E9DC8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D90")]
		[Address(RVA = "0x1BE9E18", Offset = "0x1BE9E18", VA = "0x7BBC3E9E18", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D91")]
		[Address(RVA = "0x1BEA820", Offset = "0x1BEA820", VA = "0x7BBC3EA820", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D92")]
		[Address(RVA = "0x1BEA2E0", Offset = "0x1BEA2E0", VA = "0x7BBC3EA2E0")]
		private void OnValueChange()
		{
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D93")]
		[Address(RVA = "0x1BEA8A8", Offset = "0x1BEA8A8", VA = "0x7BBC3EA8A8")]
		private void OnSendEnter()
		{
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x0001EE28 File Offset: 0x0001D028
		[Token(Token = "0x6006D94")]
		[Address(RVA = "0x1BEAB68", Offset = "0x1BEAB68", VA = "0x7BBC3EAB68")]
		protected char OnInputValidate(string text, int charIndex, char addedChar)
		{
			return '\0';
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D95")]
		[Address(RVA = "0x1BEA5B8", Offset = "0x1BEA5B8", VA = "0x7BBC3EA5B8")]
		private void RefreshDefaultInputValue()
		{
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D96")]
		[Address(RVA = "0x1BEABA0", Offset = "0x1BEABA0", VA = "0x7BBC3EABA0")]
		private void ResetDefaultInputValue()
		{
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D97")]
		[Address(RVA = "0x1BEB03C", Offset = "0x1BEB03C", VA = "0x7BBC3EB03C")]
		public UIChatSendSpeakerController()
		{
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D98")]
		[Address(RVA = "0x1BEB044", Offset = "0x1BEB044", VA = "0x7BBC3EB044")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114131C", Offset = "0x114131C")]
		private void <OnUIInit>b__5_0()
		{
		}

		// Token: 0x0400889C RID: 34972
		[Token(Token = "0x400889C")]
		[FieldOffset(Offset = "0x98")]
		private UIChatSendSpeakerView m_View;

		// Token: 0x0400889D RID: 34973
		[Token(Token = "0x400889D")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelChat m_Model;

		// Token: 0x0400889E RID: 34974
		[Token(Token = "0x400889E")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_WorldCDCallID;

		// Token: 0x0400889F RID: 34975
		[Token(Token = "0x400889F")]
		[FieldOffset(Offset = "0xB0")]
		private StringBuilder m_WorldCDText;
	}
}
