using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C28 RID: 7208
	[Token(Token = "0x2001C28")]
	public class StickerTabView : MonoBehaviour
	{
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06009CDB RID: 40155 RVA: 0x00029250 File Offset: 0x00027450
		// (set) Token: 0x06009CDC RID: 40156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A62")]
		public uint itemID
		{
			[Token(Token = "0x6009CDB")]
			[Address(RVA = "0x1B3FF28", Offset = "0x1B3FF28", VA = "0x7BBC33FF28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145368", Offset = "0x1145368")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6009CDC")]
			[Address(RVA = "0x1B3FF30", Offset = "0x1B3FF30", VA = "0x7BBC33FF30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145378", Offset = "0x1145378")]
			private set
			{
			}
		}

		// Token: 0x06009CDD RID: 40157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CDD")]
		[Address(RVA = "0x1B3FF38", Offset = "0x1B3FF38", VA = "0x7BBC33FF38")]
		private void Awake()
		{
		}

		// Token: 0x06009CDE RID: 40158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CDE")]
		[Address(RVA = "0x1B3FFEC", Offset = "0x1B3FFEC", VA = "0x7BBC33FFEC")]
		public void SetStickerTabInfo(ChatStickerPrice chatSticker)
		{
		}

		// Token: 0x06009CDF RID: 40159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CDF")]
		[Address(RVA = "0x1B4022C", Offset = "0x1B4022C", VA = "0x7BBC34022C")]
		public StickerTabView()
		{
		}

		// Token: 0x06009CE0 RID: 40160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CE0")]
		[Address(RVA = "0x1B40234", Offset = "0x1B40234", VA = "0x7BBC340234")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145388", Offset = "0x1145388")]
		private void <Awake>b__8_0()
		{
		}

		// Token: 0x0400A2DB RID: 41691
		[Token(Token = "0x400A2DB")]
		[FieldOffset(Offset = "0x18")]
		public UIToggleButton m_Button;

		// Token: 0x0400A2DC RID: 41692
		[Token(Token = "0x400A2DC")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_NameLabel;

		// Token: 0x0400A2DD RID: 41693
		[Token(Token = "0x400A2DD")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_UnselectLabel;

		// Token: 0x0400A2DE RID: 41694
		[Token(Token = "0x400A2DE")]
		[FieldOffset(Offset = "0x30")]
		public UISprite m_Icon;

		// Token: 0x0400A2DF RID: 41695
		[Token(Token = "0x400A2DF")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FAA4", Offset = "0x112FAA4")]
		private uint <itemID>k__BackingField;
	}
}
