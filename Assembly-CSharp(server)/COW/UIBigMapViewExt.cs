using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025B1 RID: 9649
	[Token(Token = "0x20025B1")]
	internal class UIBigMapViewExt : UIBigMapView
	{
		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600C691 RID: 50833 RVA: 0x000354C0 File Offset: 0x000336C0
		[Token(Token = "0x17000CD0")]
		public Vector3 MinMapLocalScale
		{
			[Token(Token = "0x600C691")]
			[Address(RVA = "0x1429844", Offset = "0x1429844", VA = "0x7BBBC29844")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600C692 RID: 50834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C692")]
		[Address(RVA = "0x142FC94", Offset = "0x142FC94", VA = "0x7BBBC2FC94")]
		public UIBigMapViewExt()
		{
		}

		// Token: 0x0600C693 RID: 50835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C693")]
		[Address(RVA = "0x142FCC4", Offset = "0x142FCC4", VA = "0x7BBBC2FCC4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C694 RID: 50836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C694")]
		[Address(RVA = "0x142974C", Offset = "0x142974C", VA = "0x7BBBC2974C")]
		public void RefreshScale()
		{
		}

		// Token: 0x0400F92D RID: 63789
		[Token(Token = "0x400F92D")]
		[FieldOffset(Offset = "0x158")]
		private float MAP_SIZE_HEIGHT;

		// Token: 0x0400F92E RID: 63790
		[Token(Token = "0x400F92E")]
		[FieldOffset(Offset = "0x15C")]
		private Vector3 m_MapLocalScale;
	}
}
