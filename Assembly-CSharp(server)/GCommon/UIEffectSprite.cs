using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001027 RID: 4135
	[Token(Token = "0x2001027")]
	[ExecuteInEditMode]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EA718", Offset = "0x10EA718")]
	public class UIEffectSprite : UISprite
	{
		// Token: 0x06003EA5 RID: 16037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x202D1A4", Offset = "0x202D1A4", VA = "0x7BBC82D1A4", Slot = "18")]
		protected override void Awake()
		{
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0x202D490", Offset = "0x202D490", VA = "0x7BBC82D490")]
		public void SetEffect(ResourceID effectResID)
		{
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x202D57C", Offset = "0x202D57C", VA = "0x7BBC82D57C")]
		private void SetEffectClip(GameObject effect)
		{
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA8")]
		[Address(RVA = "0x202D1D4", Offset = "0x202D1D4", VA = "0x7BBC82D1D4")]
		public void SetEffect(GameObject effect, bool needRemove = true)
		{
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0x202DBD8", Offset = "0x202DBD8", VA = "0x7BBC82DBD8")]
		public void UpdateEffectScale(Vector2 size)
		{
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0x202DAE4", Offset = "0x202DAE4", VA = "0x7BBC82DAE4")]
		private void SetEffectScale()
		{
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0x202D8E4", Offset = "0x202D8E4", VA = "0x7BBC82D8E4")]
		private void SetEffeectPosition()
		{
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0x202D768", Offset = "0x202D768", VA = "0x7BBC82D768")]
		public void RemoveEffect()
		{
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0x202DD80", Offset = "0x202DD80", VA = "0x7BBC82DD80")]
		public UIEffectSprite()
		{
		}

		// Token: 0x04004ED4 RID: 20180
		[Token(Token = "0x4004ED4")]
		[FieldOffset(Offset = "0x228")]
		public GameObject Effect;

		// Token: 0x04004ED5 RID: 20181
		[Token(Token = "0x4004ED5")]
		[FieldOffset(Offset = "0x230")]
		public float EffectScale;

		// Token: 0x04004ED6 RID: 20182
		[Token(Token = "0x4004ED6")]
		[FieldOffset(Offset = "0x234")]
		private ResourceID m_effectResID;

		// Token: 0x04004ED7 RID: 20183
		[Token(Token = "0x4004ED7")]
		private const int HEADSPRITE_WIDTH = 60;

		// Token: 0x04004ED8 RID: 20184
		[Token(Token = "0x4004ED8")]
		private const int HEADSPRITE_HEIGHT = 60;
	}
}
