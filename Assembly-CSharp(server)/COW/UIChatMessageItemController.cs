using System;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x020016FB RID: 5883
	[Token(Token = "0x20016FB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F132C", Offset = "0x10F132C")]
	public class UIChatMessageItemController : UIBaseChatItemController
	{
		// Token: 0x06006D5C RID: 27996 RVA: 0x0001ED20 File Offset: 0x0001CF20
		[Token(Token = "0x6006D5C")]
		[Address(RVA = "0x1BE4D94", Offset = "0x1BE4D94", VA = "0x7BBC3E4D94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D5D")]
		[Address(RVA = "0x1BE4DE4", Offset = "0x1BE4DE4", VA = "0x7BBC3E4DE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x0001ED38 File Offset: 0x0001CF38
		[Token(Token = "0x6006D5E")]
		[Address(RVA = "0x1BE4FE8", Offset = "0x1BE4FE8", VA = "0x7BBC3E4FE8", Slot = "28")]
		protected override EChannel.ChannelType GetParentChannelType()
		{
			return EChannel.ChannelType.ChannelType_GROUP;
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D5F")]
		[Address(RVA = "0x1BE5144", Offset = "0x1BE5144", VA = "0x7BBC3E5144", Slot = "29")]
		public override void OpenIteractionPanel(InteractionPopUtil.UIInteractionPoptype PopType)
		{
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D60")]
		[Address(RVA = "0x1BE5268", Offset = "0x1BE5268", VA = "0x7BBC3E5268")]
		public UIChatMessageItemController()
		{
		}

		// Token: 0x04008889 RID: 34953
		[Token(Token = "0x4008889")]
		[FieldOffset(Offset = "0xF8")]
		private UIChatMessageItemView m_View;

		// Token: 0x0400888A RID: 34954
		[Token(Token = "0x400888A")]
		public const int POPMENU_POS_X = 800;

		// Token: 0x0400888B RID: 34955
		[Token(Token = "0x400888B")]
		public const int POPMENU_POS_Y = 190;
	}
}
