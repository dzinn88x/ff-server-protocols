using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x020001A0 RID: 416
[Token(Token = "0x20001A0")]
public class UMAAssetIndexer : MonoBehaviour, ISerializationCallbackReceiver
{
	// Token: 0x06000894 RID: 2196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000894")]
	[Address(RVA = "0x25F66A4", Offset = "0x25F66A4", VA = "0x7BBCDF66A4")]
	private static Type GetAssetType(int typeIndex)
	{
		return null;
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00003A38 File Offset: 0x00001C38
	[Token(Token = "0x6000895")]
	[Address(RVA = "0x25F6754", Offset = "0x25F6754", VA = "0x7BBCDF6754")]
	private static int GetAssetTypeIndex(Type type)
	{
		return 0;
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000896 RID: 2198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000099")]
	public static UMAAssetIndexer Instance
	{
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x25F68B8", Offset = "0x25F68B8", VA = "0x7BBCDF68B8")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000897")]
	[Address(RVA = "0x25F6B9C", Offset = "0x25F6B9C", VA = "0x7BBCDF6B9C")]
	public static void Cleanup()
	{
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000898")]
	[Address(RVA = "0x25F6C9C", Offset = "0x25F6C9C", VA = "0x7BBCDF6C9C")]
	public void ClearResourceRef()
	{
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000899")]
	[Address(RVA = "0x25F71B0", Offset = "0x25F71B0", VA = "0x7BBCDF71B0")]
	public Type[] GetTypes()
	{
		return null;
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00003A50 File Offset: 0x00001C50
	[Token(Token = "0x600089A")]
	[Address(RVA = "0x25F7218", Offset = "0x25F7218", VA = "0x7BBCDF7218")]
	public bool IsIndexedType(Type type)
	{
		return default(bool);
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x00003A68 File Offset: 0x00001C68
	[Token(Token = "0x600089B")]
	[Address(RVA = "0x25F73BC", Offset = "0x25F73BC", VA = "0x7BBCDF73BC")]
	public bool IsAdditionalIndexedType(string QualifiedName)
	{
		return default(bool);
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089C")]
	[Address(RVA = "0x25F74EC", Offset = "0x25F74EC", VA = "0x7BBCDF74EC")]
	public void AddType(Type sType)
	{
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089D")]
	[Address(RVA = "0x25F76E0", Offset = "0x25F76E0", VA = "0x7BBCDF76E0")]
	public void RemoveType(Type sType)
	{
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600089E")]
	public UMAAssetIndexer.AssetItem GetAssetItem<T>(string Name)
	{
		return null;
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089F")]
	[Address(RVA = "0x25F78FC", Offset = "0x25F78FC", VA = "0x7BBCDF78FC")]
	private void GetEvilAssetNameAndHash(Type type, UnityEngine.Object o, ref string assetName, int assetHash)
	{
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A0")]
	public List<T> GetAllAssets<T>([Optional] string[] foldersToSearch) where T : UnityEngine.Object
	{
		return null;
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A1")]
	public T GetAsset<T>(int nameHash, [Optional] string[] foldersToSearch) where T : UnityEngine.Object
	{
		return null;
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A2")]
	public T GetAsset<T>(string name, [Optional] string[] foldersToSearch) where T : UnityEngine.Object
	{
		return null;
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x00003A80 File Offset: 0x00001C80
	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x25F7A14", Offset = "0x25F7A14", VA = "0x7BBCDF7A14")]
	private bool AssetFolderCheck(UMAAssetIndexer.AssetItem itemToCheck, [Optional] string[] foldersToSearch)
	{
		return default(bool);
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x25F7AD0", Offset = "0x25F7AD0", VA = "0x7BBCDF7AD0")]
	public void AddAsset(Type type, string Name, string Path, UnityEngine.Object o, bool SkipBundleCheck = false)
	{
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x25F7C40", Offset = "0x25F7C40", VA = "0x7BBCDF7C40")]
	public void AddAssetItem(UMAAssetIndexer.AssetItem ai, bool SkipBundleCheck = false)
	{
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x25F7FDC", Offset = "0x25F7FDC", VA = "0x7BBCDF7FDC")]
	private void UpdateDictionaries(bool SkipBundleCheck = false)
	{
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x25F820C", Offset = "0x25F820C", VA = "0x7BBCDF820C")]
	public void CreateLookupDictionary(Type type)
	{
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x25F8300", Offset = "0x25F8300", VA = "0x7BBCDF8300")]
	private void UpdateList()
	{
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x25F7064", Offset = "0x25F7064", VA = "0x7BBCDF7064")]
	public Dictionary<string, UMAAssetIndexer.AssetItem> GetAssetDictionary(Type type)
	{
		return null;
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x25F856C", Offset = "0x25F856C", VA = "0x7BBCDF856C")]
	public void RebuildIndex()
	{
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x25F87F4", Offset = "0x25F87F4", VA = "0x7BBCDF87F4")]
	public UMAMeshData GetBaseBoneData(bool isMale)
	{
		return null;
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x25F88E4", Offset = "0x25F88E4", VA = "0x7BBCDF88E4", Slot = "4")]
	private void OnBeforeSerialize()
	{
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x25F88E8", Offset = "0x25F88E8", VA = "0x7BBCDF88E8", Slot = "5")]
	private void OnAfterDeserialize()
	{
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x25F8988", Offset = "0x25F8988", VA = "0x7BBCDF8988")]
	public UMAAssetIndexer()
	{
	}

	// Token: 0x04000886 RID: 2182
	[Token(Token = "0x4000886")]
	public const string IndexPath = "/InternalDataStore/InGame/Resources/AssetIndexer";

	// Token: 0x04000887 RID: 2183
	[Token(Token = "0x4000887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string SortOrder;

	// Token: 0x04000888 RID: 2184
	[Token(Token = "0x4000888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string[] SortOrders;

	// Token: 0x04000889 RID: 2185
	[Token(Token = "0x4000889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Dictionary<Type, Type> TypeToLookup;

	// Token: 0x0400088A RID: 2186
	[Token(Token = "0x400088A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Type[] Types;

	// Token: 0x0400088B RID: 2187
	[Token(Token = "0x400088B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string> IndexedTypeNames;

	// Token: 0x0400088C RID: 2188
	[Token(Token = "0x400088C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<UMAAssetIndexer.AssetItem> Items;

	// Token: 0x0400088D RID: 2189
	[Token(Token = "0x400088D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UMAMeshAsset BaseMaleBone;

	// Token: 0x0400088E RID: 2190
	[Token(Token = "0x400088E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UMAMeshAsset BaseFemaleBone;

	// Token: 0x0400088F RID: 2191
	[Token(Token = "0x400088F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<Type, Dictionary<string, UMAAssetIndexer.AssetItem>> TypeLookup;

	// Token: 0x04000890 RID: 2192
	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static GameObject theIndex;

	// Token: 0x04000891 RID: 2193
	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static UMAAssetIndexer theIndexer;

	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	public enum EAssetItemType
	{
		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		EAssetItemType_Slot,
		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		EAssetItemType_Overlay,
		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		EAssetItemType_Race,
		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		EAssetItemType_TextRecipe,
		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		EAssetItemType_WardrobeRecipe,
		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		EAssetItemType_MAX
	}

	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	[Serializable]
	public class AssetItem
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009A")]
		public Type _Type
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x25F7EE0", Offset = "0x25F7EE0", VA = "0x7BBCDF7EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x25F8F64", Offset = "0x25F8F64", VA = "0x7BBCDF8F64")]
		public void ConvertToType()
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009B")]
		public string _AssetBaseName
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x25F8FE0", Offset = "0x25F8FE0", VA = "0x7BBCDF8FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009C")]
		public string AssetName
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x25F904C", Offset = "0x25F904C", VA = "0x7BBCDF904C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		public string EvilName
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x25F86C4", Offset = "0x25F86C4", VA = "0x7BBCDF86C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x25F7B64", Offset = "0x25F7B64", VA = "0x7BBCDF7B64")]
		public AssetItem(Type Type, string Name, string Path, UnityEngine.Object Item)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x25F907C", Offset = "0x25F907C", VA = "0x7BBCDF907C")]
		public AssetItem(Type Type, UnityEngine.Object Item)
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x25F9150", Offset = "0x25F9150", VA = "0x7BBCDF9150")]
		public void CheckName()
		{
		}

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string _QualifiedName;

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _TypeIndex;

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string _Name;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEngine.Object _Item;

		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string _Path;
	}
}
