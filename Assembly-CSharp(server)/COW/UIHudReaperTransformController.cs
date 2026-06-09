using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200164C RID: 5708
	[Token(Token = "0x200164C")]
	internal class UIHudReaperTransformController : UIBaseController
	{
		// Token: 0x06006705 RID: 26373 RVA: 0x0001D640 File Offset: 0x0001B840
		[Token(Token = "0x6006705")]
		[Address(RVA = "0x17ED0D8", Offset = "0x17ED0D8", VA = "0x7BBBFED0D8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006706")]
		[Address(RVA = "0x17ED128", Offset = "0x17ED128", VA = "0x7BBBFED128", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006707")]
		[Address(RVA = "0x17ED33C", Offset = "0x17ED33C", VA = "0x7BBBFED33C")]
		private void OnTransformClick()
		{
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006708")]
		[Address(RVA = "0x17ED508", Offset = "0x17ED508", VA = "0x7BBBFED508")]
		public void UpdateState()
		{
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006709")]
		[Address(RVA = "0x17EDA54", Offset = "0x17EDA54", VA = "0x7BBBFEDA54")]
		public UIHudReaperTransformController()
		{
		}

		// Token: 0x04008485 RID: 33925
		[Token(Token = "0x4008485")]
		[FieldOffset(Offset = "0x58")]
		private UIHudReaperTransformView m_View;

		// Token: 0x04008486 RID: 33926
		[Token(Token = "0x4008486")]
		[FieldOffset(Offset = "0x60")]
		private float iconDarkAlpha;

		// Token: 0x0200164D RID: 5709
		[Token(Token = "0x200164D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFF7C", Offset = "0x10EFF7C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600670B RID: 26379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600670B")]
			[Address(RVA = "0x17EDAC8", Offset = "0x17EDAC8", VA = "0x7BBBFEDAC8")]
			public <>c()
			{
			}

			// Token: 0x0600670C RID: 26380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600670C")]
			[Address(RVA = "0x17EDAD0", Offset = "0x17EDAD0", VA = "0x7BBBFEDAD0")]
			internal void <UpdateState>b__5_0(bool active)
			{
			}

			// Token: 0x0600670D RID: 26381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600670D")]
			[Address(RVA = "0x17EDC24", Offset = "0x17EDC24", VA = "0x7BBBFEDC24")]
			internal void <UpdateState>b__5_1(bool active)
			{
			}

			// Token: 0x0600670E RID: 26382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600670E")]
			[Address(RVA = "0x17EDD78", Offset = "0x17EDD78", VA = "0x7BBBFEDD78")]
			internal void <UpdateState>b__5_2(bool active)
			{
			}

			// Token: 0x04008487 RID: 33927
			[Token(Token = "0x4008487")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudReaperTransformController.<>c <>9;

			// Token: 0x04008488 RID: 33928
			[Token(Token = "0x4008488")]
			[FieldOffset(Offset = "0x8")]
			public static Action<bool> <>9__5_0;

			// Token: 0x04008489 RID: 33929
			[Token(Token = "0x4008489")]
			[FieldOffset(Offset = "0x10")]
			public static Action<bool> <>9__5_1;

			// Token: 0x0400848A RID: 33930
			[Token(Token = "0x400848A")]
			[FieldOffset(Offset = "0x18")]
			public static Action<bool> <>9__5_2;
		}
	}
}
