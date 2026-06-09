using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001026 RID: 4134
	[Token(Token = "0x2001026")]
	internal class UIEffectHelper : MonoBehaviour
	{
		// Token: 0x06003EA0 RID: 16032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA0")]
		[Address(RVA = "0x202CBE4", Offset = "0x202CBE4", VA = "0x7BBC82CBE4")]
		private void Awake()
		{
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA1")]
		[Address(RVA = "0x202CC3C", Offset = "0x202CC3C", VA = "0x7BBC82CC3C")]
		public void SetEffect(ResourceID effectResID)
		{
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA2")]
		[Address(RVA = "0x202CD08", Offset = "0x202CD08", VA = "0x7BBC82CD08")]
		public void SetEffect(GameObject effect)
		{
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA3")]
		[Address(RVA = "0x202CFB0", Offset = "0x202CFB0", VA = "0x7BBC82CFB0")]
		public void RemoveEffect()
		{
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA4")]
		[Address(RVA = "0x202D12C", Offset = "0x202D12C", VA = "0x7BBC82D12C")]
		public UIEffectHelper()
		{
		}

		// Token: 0x04004ED1 RID: 20177
		[Token(Token = "0x4004ED1")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Effect;

		// Token: 0x04004ED2 RID: 20178
		[Token(Token = "0x4004ED2")]
		[FieldOffset(Offset = "0x20")]
		private ResourceID EffectResID;

		// Token: 0x04004ED3 RID: 20179
		[Token(Token = "0x4004ED3")]
		[FieldOffset(Offset = "0x28")]
		private UIWidget BundleWidget;
	}
}
