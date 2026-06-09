using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024FB RID: 9467
	[Token(Token = "0x20024FB")]
	internal class UISPBigMapViewExt : UISPBigMapView
	{
		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x0600C506 RID: 50438 RVA: 0x00035448 File Offset: 0x00033648
		[Token(Token = "0x17000CCB")]
		public Vector3 MinMapLocalScale
		{
			[Token(Token = "0x600C506")]
			[Address(RVA = "0x1A26ACC", Offset = "0x1A26ACC", VA = "0x7BBC226ACC")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600C507 RID: 50439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C507")]
		[Address(RVA = "0x1A26AD8", Offset = "0x1A26AD8", VA = "0x7BBC226AD8")]
		public UISPBigMapViewExt()
		{
		}

		// Token: 0x0600C508 RID: 50440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C508")]
		[Address(RVA = "0x1A26B14", Offset = "0x1A26B14", VA = "0x7BBC226B14", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C509 RID: 50441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C509")]
		[Address(RVA = "0x1A26CF8", Offset = "0x1A26CF8", VA = "0x7BBC226CF8")]
		public void RefreshScale()
		{
		}

		// Token: 0x0400F14C RID: 61772
		[Token(Token = "0x400F14C")]
		[FieldOffset(Offset = "0x98")]
		private float MAP_SIZE_HEIGHT;

		// Token: 0x0400F14D RID: 61773
		[Token(Token = "0x400F14D")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 m_MapLocalScale;

		// Token: 0x0400F14E RID: 61774
		[Token(Token = "0x400F14E")]
		[FieldOffset(Offset = "0xA8")]
		private float SCALE_RATIO;
	}
}
