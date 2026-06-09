using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001452 RID: 5202
	[Token(Token = "0x2001452")]
	public class UIAvatarStateBase
	{
		// Token: 0x0600573D RID: 22333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573D")]
		[Address(RVA = "0x1E50A98", Offset = "0x1E50A98", VA = "0x7BBC650A98")]
		public void SetClothes(IEnumerable<uint> cs)
		{
		}

		// Token: 0x0600573E RID: 22334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573E")]
		[Address(RVA = "0x1E50918", Offset = "0x1E50918", VA = "0x7BBC650918")]
		public void CloneTo(UIAvatarStateBase s)
		{
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573F")]
		[Address(RVA = "0x1E509A0", Offset = "0x1E509A0", VA = "0x7BBC6509A0", Slot = "4")]
		public virtual void ResetOnceValues()
		{
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005740")]
		[Address(RVA = "0x1E50A14", Offset = "0x1E50A14", VA = "0x7BBC650A14")]
		public UIAvatarStateBase()
		{
		}

		// Token: 0x04007B83 RID: 31619
		[Token(Token = "0x4007B83")]
		[FieldOffset(Offset = "0x10")]
		public uint AvatarID;

		// Token: 0x04007B84 RID: 31620
		[Token(Token = "0x4007B84")]
		[FieldOffset(Offset = "0x14")]
		public uint CollectionId;

		// Token: 0x04007B85 RID: 31621
		[Token(Token = "0x4007B85")]
		[FieldOffset(Offset = "0x18")]
		public float SkinColorNormed;

		// Token: 0x04007B86 RID: 31622
		[Token(Token = "0x4007B86")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsLocalAvatar;

		// Token: 0x04007B87 RID: 31623
		[Token(Token = "0x4007B87")]
		[FieldOffset(Offset = "0x1D")]
		public bool UseLobbyRecipes;

		// Token: 0x04007B88 RID: 31624
		[Token(Token = "0x4007B88")]
		[FieldOffset(Offset = "0x20")]
		public List<uint> Clothes;

		// Token: 0x04007B89 RID: 31625
		[Token(Token = "0x4007B89")]
		[FieldOffset(Offset = "0x28")]
		public int ClothesNotReadyCnt;

		// Token: 0x04007B8A RID: 31626
		[Token(Token = "0x4007B8A")]
		[FieldOffset(Offset = "0x2C")]
		public bool PlayTriggerEffect;

		// Token: 0x04007B8B RID: 31627
		[Token(Token = "0x4007B8B")]
		[FieldOffset(Offset = "0x2D")]
		public bool HideSkinRendererUntilNotDirty;

		// Token: 0x04007B8C RID: 31628
		[Token(Token = "0x4007B8C")]
		[FieldOffset(Offset = "0x30")]
		public Action<bool> AvatarInitedCallbackOnce;

		// Token: 0x04007B8D RID: 31629
		[Token(Token = "0x4007B8D")]
		[FieldOffset(Offset = "0x38")]
		public Action<UIStatedAvatar> AvatarUpdateCallbackOnce;

		// Token: 0x04007B8E RID: 31630
		[Token(Token = "0x4007B8E")]
		[FieldOffset(Offset = "0x40")]
		public bool IsSkipSetAnimator;
	}
}
