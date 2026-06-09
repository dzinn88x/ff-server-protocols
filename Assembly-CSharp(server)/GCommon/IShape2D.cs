using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F10 RID: 3856
	[Token(Token = "0x2000F10")]
	public interface IShape2D
	{
		// Token: 0x0600366C RID: 13932
		[Token(Token = "0x600366C")]
		Vector3 GetPosition();

		// Token: 0x0600366D RID: 13933
		[Token(Token = "0x600366D")]
		Vector3 GetCenter();

		// Token: 0x0600366E RID: 13934
		[Token(Token = "0x600366E")]
		Vector3 GetSize();

		// Token: 0x0600366F RID: 13935
		[Token(Token = "0x600366F")]
		bool IsPointInside(Vector3 v, float margin = 0f);

		// Token: 0x06003670 RID: 13936
		[Token(Token = "0x6003670")]
		Vector3 GetRandomPoint(float margin = 0f);

		// Token: 0x06003671 RID: 13937
		[Token(Token = "0x6003671")]
		Vector3 ClampPoint(Vector3 v, float margin = 0f);
	}
}
