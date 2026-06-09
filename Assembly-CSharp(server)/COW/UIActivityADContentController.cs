using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020013DC RID: 5084
	[Token(Token = "0x20013DC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC0B8", Offset = "0x10EC0B8")]
	public class UIActivityADContentController : UIActivityContentController
	{
		// Token: 0x06005367 RID: 21351 RVA: 0x00018ED0 File Offset: 0x000170D0
		[Token(Token = "0x6005367")]
		[Address(RVA = "0x1A3E2B4", Offset = "0x1A3E2B4", VA = "0x7BBC23E2B4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005368")]
		[Address(RVA = "0x1A3E304", Offset = "0x1A3E304", VA = "0x7BBC23E304", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005369")]
		[Address(RVA = "0x1A3E638", Offset = "0x1A3E638", VA = "0x7BBC23E638", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536A")]
		[Address(RVA = "0x1A3E93C", Offset = "0x1A3E93C", VA = "0x7BBC23E93C")]
		private void OnGoToClick()
		{
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536B")]
		[Address(RVA = "0x1A3EA74", Offset = "0x1A3EA74", VA = "0x7BBC23EA74")]
		private void SendBannerClickLog(uint id)
		{
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536C")]
		[Address(RVA = "0x1A3EBE8", Offset = "0x1A3EBE8", VA = "0x7BBC23EBE8", Slot = "29")]
		public override void Reload()
		{
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536D")]
		[Address(RVA = "0x1A3EC88", Offset = "0x1A3EC88", VA = "0x7BBC23EC88")]
		public UIActivityADContentController()
		{
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536E")]
		[Address(RVA = "0x1A3EC90", Offset = "0x1A3EC90", VA = "0x7BBC23EC90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E4D0", Offset = "0x113E4D0")]
		private void <OnUIInit>b__5_0(GameObject e)
		{
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536F")]
		[Address(RVA = "0x1A3EC94", Offset = "0x1A3EC94", VA = "0x7BBC23EC94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E4E0", Offset = "0x113E4E0")]
		private void <SetData>b__6_0()
		{
		}

		// Token: 0x04007924 RID: 31012
		[Token(Token = "0x4007924")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityADContentView m_View;

		// Token: 0x04007925 RID: 31013
		[Token(Token = "0x4007925")]
		[FieldOffset(Offset = "0x60")]
		private UIActivityADContentController.Data m_Data;

		// Token: 0x04007926 RID: 31014
		[Token(Token = "0x4007926")]
		[FieldOffset(Offset = "0x68")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x020013DD RID: 5085
		[Token(Token = "0x20013DD")]
		public class Data
		{
			// Token: 0x06005370 RID: 21360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005370")]
			[Address(RVA = "0x1A3EF14", Offset = "0x1A3EF14", VA = "0x7BBC23EF14")]
			public Data()
			{
			}

			// Token: 0x04007927 RID: 31015
			[Token(Token = "0x4007927")]
			[FieldOffset(Offset = "0x10")]
			public uint id;

			// Token: 0x04007928 RID: 31016
			[Token(Token = "0x4007928")]
			[FieldOffset(Offset = "0x14")]
			public uint groupId;

			// Token: 0x04007929 RID: 31017
			[Token(Token = "0x4007929")]
			[FieldOffset(Offset = "0x18")]
			public string url;

			// Token: 0x0400792A RID: 31018
			[Token(Token = "0x400792A")]
			[FieldOffset(Offset = "0x20")]
			public uint goPos;

			// Token: 0x0400792B RID: 31019
			[Token(Token = "0x400792B")]
			[FieldOffset(Offset = "0x28")]
			public string subGoPos;

			// Token: 0x0400792C RID: 31020
			[Token(Token = "0x400792C")]
			[FieldOffset(Offset = "0x30")]
			public bool prefersExternal;

			// Token: 0x0400792D RID: 31021
			[Token(Token = "0x400792D")]
			[FieldOffset(Offset = "0x31")]
			public bool enableGotoButton;
		}
	}
}
