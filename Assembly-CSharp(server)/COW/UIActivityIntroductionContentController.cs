using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013F2 RID: 5106
	[Token(Token = "0x20013F2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC2F8", Offset = "0x10EC2F8")]
	public class UIActivityIntroductionContentController : UIActivityContentController
	{
		// Token: 0x060053FD RID: 21501 RVA: 0x00019140 File Offset: 0x00017340
		[Token(Token = "0x60053FD")]
		[Address(RVA = "0x1953E30", Offset = "0x1953E30", VA = "0x7BBC153E30")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060053FE RID: 21502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053FE")]
		[Address(RVA = "0x1953E80", Offset = "0x1953E80", VA = "0x7BBC153E80", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053FF")]
		[Address(RVA = "0x1953FBC", Offset = "0x1953FBC", VA = "0x7BBC153FBC", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005400")]
		[Address(RVA = "0x1954170", Offset = "0x1954170", VA = "0x7BBC154170")]
		public void GoTo()
		{
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005401")]
		[Address(RVA = "0x195428C", Offset = "0x195428C", VA = "0x7BBC15428C", Slot = "29")]
		public override void Reload()
		{
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005402")]
		[Address(RVA = "0x1954334", Offset = "0x1954334", VA = "0x7BBC154334")]
		public UIActivityIntroductionContentController()
		{
		}

		// Token: 0x0400797D RID: 31101
		[Token(Token = "0x400797D")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityIntroductionContentView m_View;

		// Token: 0x0400797E RID: 31102
		[Token(Token = "0x400797E")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x0400797F RID: 31103
		[Token(Token = "0x400797F")]
		[FieldOffset(Offset = "0x68")]
		private UIActivityIntroductionContentController.Data m_Data;

		// Token: 0x020013F3 RID: 5107
		[Token(Token = "0x20013F3")]
		public class Data
		{
			// Token: 0x06005403 RID: 21507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005403")]
			[Address(RVA = "0x195433C", Offset = "0x195433C", VA = "0x7BBC15433C")]
			public Data(uint groupId, string introduction, uint goPos, string subGoPos, bool prefersExternal)
			{
			}

			// Token: 0x04007980 RID: 31104
			[Token(Token = "0x4007980")]
			[FieldOffset(Offset = "0x10")]
			public uint groupId;

			// Token: 0x04007981 RID: 31105
			[Token(Token = "0x4007981")]
			[FieldOffset(Offset = "0x18")]
			public string introduction;

			// Token: 0x04007982 RID: 31106
			[Token(Token = "0x4007982")]
			[FieldOffset(Offset = "0x20")]
			public uint goPos;

			// Token: 0x04007983 RID: 31107
			[Token(Token = "0x4007983")]
			[FieldOffset(Offset = "0x28")]
			public string subGoPos;

			// Token: 0x04007984 RID: 31108
			[Token(Token = "0x4007984")]
			[FieldOffset(Offset = "0x30")]
			public bool prefersExternal;
		}
	}
}
