using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001448 RID: 5192
	[Token(Token = "0x2001448")]
	public class ReplaceAnimData
	{
		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06005676 RID: 22134 RVA: 0x00019A88 File Offset: 0x00017C88
		[Token(Token = "0x1700088A")]
		public bool HasOverrideAnim
		{
			[Token(Token = "0x6005676")]
			[Address(RVA = "0x1759414", Offset = "0x1759414", VA = "0x7BBBF59414")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005677")]
		[Address(RVA = "0x175948C", Offset = "0x175948C", VA = "0x7BBBF5948C")]
		public void ResetDefaultAnim()
		{
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005678")]
		[Address(RVA = "0x17594C8", Offset = "0x17594C8", VA = "0x7BBBF594C8")]
		public void ResetOverrideAnim()
		{
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005679")]
		[Address(RVA = "0x17595B0", Offset = "0x17595B0", VA = "0x7BBBF595B0")]
		public void SetOverrideAnim(string slot, ResourceID id)
		{
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567A")]
		[Address(RVA = "0x17595C4", Offset = "0x17595C4", VA = "0x7BBBF595C4")]
		public void SetOverrideAnim(ResourceID id)
		{
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567B")]
		[Address(RVA = "0x17595D4", Offset = "0x17595D4", VA = "0x7BBBF595D4")]
		public void SetEffect(ResourceID id)
		{
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567C")]
		[Address(RVA = "0x17595E4", Offset = "0x17595E4", VA = "0x7BBBF595E4")]
		public void SetEnabled(bool b)
		{
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600567D RID: 22141 RVA: 0x00019AA0 File Offset: 0x00017CA0
		[Token(Token = "0x1700088B")]
		public bool EnableAndReplaced
		{
			[Token(Token = "0x600567D")]
			[Address(RVA = "0x175961C", Offset = "0x175961C", VA = "0x7BBBF5961C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567E")]
		[Address(RVA = "0x175963C", Offset = "0x175963C", VA = "0x7BBBF5963C")]
		public ReplaceAnimData()
		{
		}

		// Token: 0x04007B15 RID: 31509
		[Token(Token = "0x4007B15")]
		[FieldOffset(Offset = "0x10")]
		public bool Enabled;

		// Token: 0x04007B16 RID: 31510
		[Token(Token = "0x4007B16")]
		[FieldOffset(Offset = "0x11")]
		public bool Replaced;

		// Token: 0x04007B17 RID: 31511
		[Token(Token = "0x4007B17")]
		[FieldOffset(Offset = "0x12")]
		public bool Dirty;

		// Token: 0x04007B18 RID: 31512
		[Token(Token = "0x4007B18")]
		[FieldOffset(Offset = "0x18")]
		public AnimationClip DefaultAnim;

		// Token: 0x04007B19 RID: 31513
		[Token(Token = "0x4007B19")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID OverrideAnimID;

		// Token: 0x04007B1A RID: 31514
		[Token(Token = "0x4007B1A")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID EffectID;

		// Token: 0x04007B1B RID: 31515
		[Token(Token = "0x4007B1B")]
		[FieldOffset(Offset = "0x28")]
		public string OverrideSlotName;
	}
}
