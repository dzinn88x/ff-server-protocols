using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EEC RID: 3820
	[Token(Token = "0x2000EEC")]
	internal class AnimationConfigDataManager : SingletonModule<AnimationConfigDataManager>
	{
		// Token: 0x06003543 RID: 13635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003543")]
		[Address(RVA = "0x25D94B4", Offset = "0x25D94B4", VA = "0x7BBCDD94B4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003544")]
		[Address(RVA = "0x25D955C", Offset = "0x25D955C", VA = "0x7BBCDD955C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003545")]
		[Address(RVA = "0x25D9898", Offset = "0x25D9898", VA = "0x7BBCDD9898")]
		public AnimationBlendConfigData GetAnimBlendConfigData(AnimationID fadeOut, AnimationID fadeIn)
		{
			return null;
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003546")]
		[Address(RVA = "0x25D9A00", Offset = "0x25D9A00", VA = "0x7BBCDD9A00")]
		public AnimationConfigData GetAnimConfigData(int id)
		{
			return null;
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003547")]
		[Address(RVA = "0x25D9AAC", Offset = "0x25D9AAC", VA = "0x7BBCDD9AAC")]
		public AnimationConfigDataManager()
		{
		}

		// Token: 0x040048AA RID: 18602
		[Token(Token = "0x40048AA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<AnimationID, AnimationConfigData> m_AnimConfigDatas;

		// Token: 0x040048AB RID: 18603
		[Token(Token = "0x40048AB")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<long, AnimationBlendConfigData> m_AnimBlendConfigDatas;
	}
}
