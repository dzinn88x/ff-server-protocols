using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C27 RID: 7207
	[Token(Token = "0x2001C27")]
	public class StickerSpriteView : MonoBehaviour
	{
		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06009CD5 RID: 40149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009CD6 RID: 40150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A61")]
		public ChatStickerData m_Data
		{
			[Token(Token = "0x6009CD5")]
			[Address(RVA = "0x1B3FCBC", Offset = "0x1B3FCBC", VA = "0x7BBC33FCBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145338", Offset = "0x1145338")]
			get
			{
				return null;
			}
			[Token(Token = "0x6009CD6")]
			[Address(RVA = "0x1B3FCC4", Offset = "0x1B3FCC4", VA = "0x7BBC33FCC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145348", Offset = "0x1145348")]
			private set
			{
			}
		}

		// Token: 0x06009CD7 RID: 40151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CD7")]
		[Address(RVA = "0x1B3FCCC", Offset = "0x1B3FCCC", VA = "0x7BBC33FCCC")]
		private void Awake()
		{
		}

		// Token: 0x06009CD8 RID: 40152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CD8")]
		[Address(RVA = "0x1B3FD80", Offset = "0x1B3FD80", VA = "0x7BBC33FD80")]
		public void SetStickerSprite(ChatStickerData data)
		{
		}

		// Token: 0x06009CD9 RID: 40153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CD9")]
		[Address(RVA = "0x1B3FE1C", Offset = "0x1B3FE1C", VA = "0x7BBC33FE1C")]
		public StickerSpriteView()
		{
		}

		// Token: 0x06009CDA RID: 40154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CDA")]
		[Address(RVA = "0x1B3FE24", Offset = "0x1B3FE24", VA = "0x7BBC33FE24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145358", Offset = "0x1145358")]
		private void <Awake>b__6_0()
		{
		}

		// Token: 0x0400A2D8 RID: 41688
		[Token(Token = "0x400A2D8")]
		[FieldOffset(Offset = "0x18")]
		public UIButton m_Button;

		// Token: 0x0400A2D9 RID: 41689
		[Token(Token = "0x400A2D9")]
		[FieldOffset(Offset = "0x20")]
		public UISprite m_StickerSprite;

		// Token: 0x0400A2DA RID: 41690
		[Token(Token = "0x400A2DA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FA94", Offset = "0x112FA94")]
		private ChatStickerData <m_Data>k__BackingField;
	}
}
